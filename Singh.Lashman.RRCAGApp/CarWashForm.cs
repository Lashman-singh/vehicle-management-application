/**
 ** Name: Lashman Singh
 ** Program: Business Information Technology
 ** Course: ADEV - 2008 Programming 2
 ** Created: { 25 - 11 - 2023 }
 ** Updated: { 25 - 11 - 2023 }
 **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using ACE.BIT.ADEV.CarWash;
using ACE.BIT.ADEV.Forms;
using Singh.Lashman.Business;

namespace Singh.Lashman.RRCAGApp
{
    public partial class CarWashForm : ACE.BIT.ADEV.Forms.CarWashForm
    {
        private const decimal ProvincialSalesTaxRate = 0.07m;
        private const decimal GoodsAndServiceTaxRate = 0.05m;

        private BindingList<string> packagesList;
        private BindingSource packagesBindingSource;

        private BindingList<CarWashItem> fragranceList;
        private BindingSource fragranceBindingSource;

        private BindingList<string> exteriorServiceList;
        private BindingSource exteriorServiceBindingSource;

        private BindingList<string> interiorServiceList;
        private BindingSource interiorServiceBindingSource;

        private CarWashInvoice carWash;
        private BindingSource carWashBindingSource;

        /// <summary>
        /// Initialize a CarWashForm class.
        /// </summary>
        public CarWashForm()
        {
            InitializeComponent();
            this.Load += CarWashForm_Load;
            this.packagesList = new BindingList<string>();
            this.packagesBindingSource = new BindingSource();
            this.fragranceList = new BindingList<CarWashItem>();
            this.fragranceBindingSource = new BindingSource();
            this.exteriorServiceList = new BindingList<string>();
            this.exteriorServiceBindingSource = new BindingSource();
            this.interiorServiceList = new BindingList<string>();
            this.interiorServiceBindingSource = new BindingSource();
            this.carWashBindingSource = new BindingSource();
            this.mnuToolsGenerateInvoice.Click += MnuToolsGenerateInvoice_Click;
            this.mnuFileClose.Click += MnuFileClose_Click;
        }

        private void CarWashForm_Load(object sender, EventArgs e)
        {
            this.Text = "Car Wash";
            this.mnuToolsGenerateInvoice.Enabled = false;
            BindingData();
            readDataFormFile();
            GetPackages();
            this.Size = new System.Drawing.Size(418, 500);
            this.cboPackage.SelectedIndex = -1;
            this.cboFragrance.ValueMember = "Description";
            this.cboFragrance.SelectedValue = "Pine";
            this.cboPackage.SelectedIndexChanged += CalculateCarWashServices;
            this.cboFragrance.SelectedIndexChanged += CalculateCarWashServices;
        }

        private void readDataFormFile()
        {
            string filepath = "fragrances.txt";

            // Create a FileStream which opens the file for reading only.
            FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);

            // Check filePath is exists on intended path or not and display the MessageBox.
            if (!File.Exists(filepath))
            {
                string errorMessage = "Fragrance data file not found.";
                string caption = "Data File Error";
                MessageBox.Show(errorMessage, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }

            // Creates a StreamReader which reads text from a FileStream.
            StreamReader fileReader = new StreamReader(fileStream);

            //Creates a collection to store the data read from the file.
            List<CarWashItem> fragranceList = new List<CarWashItem>();
            fragranceList.Add(new CarWashItem("Pine", 0));

            try
            {
                // Loop while there is more data to read
                while (fileReader.Peek() != -1)
                {
                    // Read a record (line) from the file
                    string record = fileReader.ReadLine();

                    char[] delemiteres = { ',' };

                    string[] field = record.Split(delemiteres);

                    // Each field is stored as an element in the array
                    string fragranceName = field[0];
                    decimal fragrancePrice = Decimal.Parse(field[1]);

                    if (!fragranceName.Equals("Pine"))
                    {
                        fragranceList.Add(new CarWashItem(fragranceName, fragrancePrice));
                    }
                }
                fragranceList.Sort();
                foreach (CarWashItem item in fragranceList)
                {
                    this.fragranceList.Add(item);
                }
            }
            catch (Exception)
            {
                string errorMessage = "An error occurred while reading the data file.";
                string caption = "Data File Error";
                MessageBox.Show(errorMessage, caption, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
        }

        private void GetPackages()
        {
            string[] packages = { "Standard", "Deluxe", "Executive", "Luxury" };

            foreach (string package in packages)
            {
                this.packagesList.Add(package);
            }
        }

        private void BindingData()
        {
            this.packagesBindingSource.DataSource = this.packagesList;
            this.cboPackage.DataSource = this.packagesBindingSource;

            this.fragranceBindingSource.DataSource = this.fragranceList;
            this.cboFragrance.DataSource = this.fragranceBindingSource;

            this.exteriorServiceBindingSource.DataSource = this.exteriorServiceList;
            this.lstExterior.DataSource = this.exteriorServiceBindingSource;

            this.interiorServiceBindingSource.DataSource = this.interiorServiceList;
            this.lstInterior.DataSource = this.interiorServiceBindingSource;

            this.carWashBindingSource.DataSource = typeof(CarWashInvoice);

            Binding subTotalBind = new Binding("Text", this.carWashBindingSource, "Subtotal", true);
            subTotalBind.FormatString = "C";
            this.lblSubtotal.DataBindings.Add(subTotalBind);

            Binding pstBind = new Binding("Text", this.carWashBindingSource, "ProvincialSalesTaxCharged", true);
            pstBind.FormatString = "N2";
            this.lblProvincialSalesTax.DataBindings.Add(pstBind);

            Binding gstBind = new Binding("Text", this.carWashBindingSource, "GoodsAndServicesTaxCharged");
            gstBind.FormatString = "N";
            this.lblGoodsAndServicesTax.DataBindings.Add(gstBind);

            Binding totalBind = new Binding("Text", this.carWashBindingSource, "Total", true);
            totalBind.FormatString = "C";
            this.lblTotal.DataBindings.Add(totalBind);
        }

        private void CalculateCarWashServices(object sender, EventArgs e)
        {
            if (this.cboPackage.SelectedIndex > -1)
            {
                this.interiorServiceList.Clear();
                this.exteriorServiceBindingSource.Clear();

                string fragranceName = this.cboFragrance.SelectedItem.ToString();
                decimal fragranceCost = 0;

                foreach (CarWashItem fragrance in this.fragranceList)
                {
                    if (fragrance.ToString() == fragranceName)
                    {
                        fragranceCost = fragrance.Price;
                    }
                }

                string[] packageDescriptions = { "Standard", "Deluxe", "Executive", "Luxury" };
                decimal[] packagePrices = { 7.50m, 15.00m, 35.00m, 55.00m };
                string[] interiorServices = { "Fragrance-", this.cboFragrance.SelectedItem.ToString(), "Shampoo Upholstery", "Interior Protection Coat" };
                string[] exteriorServices = { "Hand Wash", "Handle Wax", "Wheel Polish", "Detail Engine Compartment" };

                decimal packageCost = packagePrices[this.cboPackage.SelectedIndex];

                for (int services = 0; services <= this.cboPackage.SelectedIndex; services++)
                {
                    this.interiorServiceList.Add(interiorServices[services]);
                    this.exteriorServiceList.Add(exteriorServices[services]);
                }

                this.carWash = new CarWashInvoice(ProvincialSalesTaxRate, GoodsAndServiceTaxRate, packageCost, fragranceCost);
                this.carWashBindingSource.DataSource = this.carWash;
                this.mnuToolsGenerateInvoice.Enabled = true;
            }
        }


        private void CarWashInvoiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.interiorServiceList.Clear();
            this.exteriorServiceList.Clear();
            this.carWashBindingSource.Clear();
            this.cboPackage.SelectedIndex = -1;
            this.cboFragrance.SelectedValue = "Pine";
            this.mnuToolsGenerateInvoice.Enabled = false;
        }

        private void MnuToolsGenerateInvoice_Click(object sender, EventArgs e)
        {
            CarWashInvoiceForm carWashInvoiceForm = new CarWashInvoiceForm(this.carWashBindingSource);
            carWashInvoiceForm.FormClosed += CarWashInvoiceForm_FormClosed;
            carWashInvoiceForm.ShowDialog();
        }

        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(this.Close));
        }
    }
}
