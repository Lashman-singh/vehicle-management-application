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
using System.Diagnostics;
using System.Security.Cryptography;
using System.Runtime.Remoting.Channels;

namespace Singh.Lashman.RRCAGApp
{
    public partial class SalesQuoteForm : Form
    {
        private SalesQuote sales;
        Accessories accessories = Accessories.None;
        ExteriorFinish exteriorFinishChosen = ExteriorFinish.None;

        public SalesQuoteForm()
        {
            InitializeComponent();
            InitialState();

            this.btnCalculate.Click += BtnCalculate_Click;
            this.txtVehicleSalesPrice.TextChanged += TxtVehicleSalesPrice_TextChanged;
            this.txtTradeInValue.TextChanged += TxtTradeInValue_TextChanged;
            this.cboxComputerNavigation.CheckedChanged += CboxComputerNavigation_CheckedChanged;
            this.cboxLeatherInterior.CheckedChanged += CboxLeatherInterior_CheckedChanged;
            this.cboxStereoSystem.CheckedChanged += CboxStereoSystem_CheckedChanged;
            this.rbtnCustomizedDetailing.CheckedChanged += RbtnCustomizedDetailing_CheckedChanged;
            this.rbtnPearlized.CheckedChanged += RbtnPearlized_CheckedChanged;
            this.rbtnStandard.CheckedChanged += RbtnStandard_CheckedChanged;
            this.nudAnnualInterestRate.ValueChanged += NudAnnualInterestRate_ValueChanged;
            this.nudNoOfYears.ValueChanged += NudNoOfYears_ValueChanged;
            this.btnReset.Click += BtnReset_Click;
        }

        private void NudNoOfYears_ValueChanged(object sender, EventArgs e)
        {
            if (sales != null)
            {
                GBoxSummary();
                Options();
                Finance();
                BtnCalculate_Click(sender, e);
            }
        }

        private void NudAnnualInterestRate_ValueChanged(object sender, EventArgs e)
        {
            if (sales != null)
            {
                GBoxSummary();
                Options();
                Finance();
                BtnCalculate_Click(sender, e);
            }
        }

        private void RbtnStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (sales != null)
            {
                GBoxSummary();
                Options();
                Finance();
                BtnCalculate_Click(sender, e);
            }
        }

        private void RbtnPearlized_CheckedChanged(object sender, EventArgs e)
        {
            if (sales != null)
            {
                GBoxSummary();
                Options();
                Finance();
                BtnCalculate_Click(sender, e);
            }
        }

        private void RbtnCustomizedDetailing_CheckedChanged(object sender, EventArgs e)
        {
            if (sales != null)
            {
                GBoxSummary();
                Options();
                Finance();
                BtnCalculate_Click(sender, e);
            }
        }

        private void CboxStereoSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (sales != null)
            {
                GBoxSummary();
                Options();
                Finance();
                BtnCalculate_Click(sender, e);
            }
        }

        private void CboxLeatherInterior_CheckedChanged(object sender, EventArgs e)
        {
            if (sales != null)
            {
                GBoxSummary();
                Options();
                Finance();
                BtnCalculate_Click(sender, e);
            }
        }

        private void CboxComputerNavigation_CheckedChanged(object sender, EventArgs e)
        {
            if (sales != null)
            {
                GBoxSummary();
                Options();
                Finance();
                BtnCalculate_Click(sender, e);
            }
        }
        
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            bool vehicleSalesPrice = decimal.TryParse(this.txtVehicleSalesPrice.Text, out decimal price);
            bool tradeAmount = decimal.TryParse(this.txtTradeInValue.Text, out decimal amount);

            if (String.IsNullOrEmpty(this.txtVehicleSalesPrice.Text))
            {

                errorProvider.SetError(this.txtVehicleSalesPrice, "Vehicle price is a required field.");
            }
            else
            {
                if (!decimal.TryParse(this.txtVehicleSalesPrice.Text, out decimal prices))
                {
                    errorProvider.SetError(this.txtVehicleSalesPrice, "Vehicle price cannot contain letters or special characters.");
                }

                else if (price <= 0)
                {
                    errorProvider.SetError(this.txtVehicleSalesPrice, "Vehicle price cannot be less than or equal to 0.");
                }
            }



            if (String.IsNullOrEmpty(this.txtTradeInValue.Text))
            {

                errorProvider.SetError(this.txtTradeInValue, "Trade-in value is a required field.");

            }

            else
            {
                if (!decimal.TryParse(this.txtTradeInValue.Text, out decimal amounts))
                {

                    errorProvider.SetError(this.txtTradeInValue, "Trade-in value cannot contain letters or special characters.");

                }

                else if (amount < 0)
                {
                    errorProvider.SetError(this.txtTradeInValue, "Trade-in value cannot be less than 0.");
                }

                if (errorProvider.GetError(this.txtTradeInValue) == string.Empty && errorProvider.GetError(txtVehicleSalesPrice) == String.Empty)
                {

                    if (amount > price)
                    {
                        errorProvider.SetError(this.txtTradeInValue, "Trade-in value cannot exceed the vehicle sale price.");
                    }

                    else
                    {
                        decimal salesTaxRate = 0.12m;
                        Accessory();
                        Exterior();
                        sales = new SalesQuote(price, amount, salesTaxRate, accessories, exteriorFinishChosen);
                        GBoxSummary();
                        Finance();
                    }
                }
            }
        }
        /// <summary>
        ///  Gives the value type either in currency or numbers
        /// </summary>
        private void GBoxSummary()
        {
            this.lblTVehicleSalesPrice.Text = sales.VehicleSalePrice.ToString("C");
            this.lblTOptions.Text = sales.TotalOptions.ToString("N");
            this.lblTSubtotal.Text = sales.SalesTax.ToString("C");
            this.lblTSalesTax.Text = sales.SubTotal.ToString("N");
            this.lblTTotal.Text = sales.Total.ToString("C");
            this.lblTAmountDue.Text = sales.AmountDue.ToString("C");
            this.lblTTradeIn.Text = (-sales.TradeInAmount).ToString("N");
        }

        private void TxtTradeInValue_TextChanged(object sender, EventArgs e)
        {
            this.lblTVehicleSalesPrice.Text = string.Empty;
            this.lblTOptions.Text = string.Empty;
            this.lblTSubtotal.Text = string.Empty;
            this.lblTSalesTax.Text = string.Empty;
            this.lblTTotal.Text = string.Empty;
            this.lblTTradeIn.Text = string.Empty;
            this.lblTAmountDue.Text = string.Empty;
            this.lblTMonthlyPayment.Text = string.Empty;
        }

        private void TxtVehicleSalesPrice_TextChanged(object sender, EventArgs e)
        {
            this.lblTVehicleSalesPrice.Text = string.Empty;
            this.lblTOptions.Text = string.Empty;
            this.lblTSubtotal.Text = string.Empty;
            this.lblTSalesTax.Text = string.Empty;
            this.lblTTotal.Text = string.Empty;
            this.lblTTradeIn.Text = string.Empty;
            this.lblTAmountDue.Text = string.Empty;
            this.lblTMonthlyPayment.Text = string.Empty;
        }

        /// <summary>
        /// Make empty to all label values.
        /// </summary>
        private void InitialComponent()
        {
            this.txtVehicleSalesPrice.Text = string.Empty;
            this.txtTradeInValue.Text = string.Empty;
            this.lblTVehicleSalesPrice.Text = string.Empty;
            this.lblTOptions.Text = string.Empty;
            this.lblTSubtotal.Text = string.Empty;
            this.lblTSalesTax.Text = string.Empty;
            this.lblTTotal.Text = string.Empty;
            this.lblTTradeIn.Text = string.Empty;
            this.lblTAmountDue.Text = string.Empty;
            this.lblTMonthlyPayment.Text = string.Empty;
        }

        /// <summary>
        /// Handle the Click event of reset button in the form.
        /// </summary>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            string text = "Do you want to reset the form?";
            string caption = "Reset Form";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result;

            result = MessageBox.Show(text, caption, buttons, icon, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                InitialComponent();
                this.lblTMonthlyPayment.Text = string.Empty;
            }

            // Set focus back to the vehicle sale price input field
            this.txtVehicleSalesPrice.Focus();
            this.txtTradeInValue.Text = "0";
        }

        public void Options()
        {
            if (this.cboxStereoSystem.Checked)
            {
                if (this.cboxLeatherInterior.Checked)
                {
                    if (this.cboxComputerNavigation.Checked)
                    {
                        accessories = Accessories.All;
                    }
                    else
                    {
                        accessories = Accessories.StereoAndLeather;
                    }
                }
                else if (this.cboxComputerNavigation.Checked)
                {
                    accessories = Accessories.StereoAndNavigation;
                }
                else
                {
                    accessories = Accessories.StereoSystem;
                }
            }

            else if (this.cboxLeatherInterior.Checked)
            {
                accessories = Accessories.LeatherInterior;
            }
            else
            {
                accessories = Accessories.None;
            }

            if (this.rbtnCustomizedDetailing.Checked)
            {
                exteriorFinishChosen = ExteriorFinish.Custom;
            }

            if (this.rbtnStandard.Checked)
            {
                exteriorFinishChosen = ExteriorFinish.Standard;
            }

            if (this.rbtnPearlized.Checked)
            {
                exteriorFinishChosen = ExteriorFinish.Pearlized;
            }
            if (sales != null)
            {
                sales.ExteriorFinishChosen = exteriorFinishChosen;
                sales.AccessoriesChosen = accessories;
            }

            else if (this.cboxComputerNavigation.Checked)
            {
                if (this.cboxLeatherInterior.Checked)
                {
                    accessories = Accessories.LeatherAndNavigation;
                }
                else
                {
                    accessories = Accessories.ComputerNavigation;
                }

            }
        }

        public void Accessory()
        { 
            if (this.cboxStereoSystem.Checked)
            {
                if (this.cboxLeatherInterior.Checked)
                {
                    if (this.cboxComputerNavigation.Checked)
                    {
                        accessories = Accessories.All;
                    }
                    else
                    {
                        accessories = Accessories.StereoAndLeather;
                    }
                }
                else if (this.cboxComputerNavigation.Checked)
                {
                    accessories = Accessories.StereoAndNavigation;
                }
                else
                {
                    accessories = Accessories.StereoSystem;
                }
            }
            else if (this.cboxComputerNavigation.Checked)
            {
                if (this.cboxLeatherInterior.Checked)
                {
                    accessories = Accessories.LeatherAndNavigation;
                }
                else
                {
                    accessories = Accessories.ComputerNavigation;
                }
            }
            else if (this.cboxLeatherInterior.Checked)
            {
                accessories = Accessories.LeatherInterior;
            }
            else
            {
                accessories = Accessories.None;
            }
            if (sales != null)
            {
                sales.AccessoriesChosen = accessories;
            }
        }

        public void Exterior()
        {
            if (this.rbtnCustomizedDetailing.Checked)
            {
                exteriorFinishChosen = ExteriorFinish.Custom;
            }

            if (this.rbtnStandard.Checked)
            {
                exteriorFinishChosen = ExteriorFinish.Standard;
            }

            if (this.rbtnPearlized.Checked)
            {
                exteriorFinishChosen = ExteriorFinish.Pearlized;
            }

            if (sales != null)
            {
                sales.ExteriorFinishChosen = exteriorFinishChosen;
            }
        }

        public void Finance()
        {
            decimal rate = Math.Round(this.nudAnnualInterestRate.Value / 1200, 3);
            decimal value = (decimal)sales.AmountDue;
            int years = (int)this.nudNoOfYears.Value * 12;
            this.lblTMonthlyPayment.Text = Financial.GetPayment(rate, years, value).ToString("{0:C}");
        }

        public void InitialState()
        {
            txtVehicleSalesPrice.Text = string.Empty;
            txtVehicleSalesPrice.Focus();
            txtTradeInValue.Text = "0";
            lblTMonthlyPayment.Text = string.Empty;
            cboxStereoSystem.Checked = false;
            cboxLeatherInterior.Checked = false;
            cboxComputerNavigation.Checked = false;
            rbtnStandard.Checked = true;
            lblTVehicleSalesPrice.Text = string.Empty;
            lblTOptions.Text = string.Empty;
            lblTSubtotal.Text = string.Empty;
            lblTSalesTax.Text = string.Empty;
            lblTTotal.Text = string.Empty;
            lblTTradeIn.Text = string.Empty;
            lblTAmountDue.Text = string.Empty;
            nudAnnualInterestRate.Value = 5.00M; ;

            errorProvider.Clear();
        }
    }
}

