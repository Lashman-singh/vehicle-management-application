/**
 ** Name: Lashman Singh
 ** Program: Business Information Technology
 ** Course: ADEV - 2008 Programming 2
 ** Created: { 05 - 11 - 2023 }
 ** Updated: { 05 - 11 - 2023 }
 **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Singh.Lashman.Business;
using ACE.BIT.ADEV;
using ACE.BIT.ADEV.Forms;


namespace Singh.Lashman.RRCAGApp
{
    /// <summary>
    /// The main Form for the application inherits the Windows Form class.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initialize an instance of the MainF
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            this.mnuFileExit.Click += MnuFileExit_Click;
            this.mnuHelpAbout.Click += MnuHelpAbout_Click;

            // Vehicle Sales Quote 
            this.mnuFileOpenSalesQuote.Click += MnuFileOpenSalesQuote_Click;

            // Car Wash Form
            this.mnuFileOpenCarWash.Click += MnuFileOpenCarWash_Click;

            //Vehicle Data Form
            this.mnuDataVehicles.Click += MnuDataVehicles_Click;

        }

        /// <summary>
        /// Handles the click event of the DataVehicles  menuStrip of VehicleData Class.
        /// </summary>
        private void MnuDataVehicles_Click(object sender, EventArgs e)
        {
            VehicleDataForm vehicleData = new VehicleDataForm();
            vehicleData.MdiParent = this;
            vehicleData.Show();
        }

        /// <summary>
        /// Handles the click event  of the file open menu strip of carWash class.
        /// </summary>
        private void MnuFileOpenCarWash_Click(object sender, EventArgs e)
        {
            CarWashForm carWash = new CarWashForm();
            carWash.MdiParent = this;
            carWash.Show();
        }

        /// <summary>
        /// Handles the Click event of SalesQuote button of menu strip.
        /// </summary>
        private void MnuFileOpenSalesQuote_Click(object sender, EventArgs e)
        {
            SalesQuoteForm salesForm = new SalesQuoteForm();
            salesForm.MdiParent = this;
            salesForm.Show();
        }

        /// <summary>
        /// Handles the Click event which opens the about form after clicking on about tab of menu strip.
        /// </summary>
        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        /// <summary>
        ///  Handles the click event of the exit menu items.
        /// </summary>
        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
