namespace Singh.Lashman.RRCAGApp
{
    partial class SalesQuoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblVehicleSalesPrice = new System.Windows.Forms.Label();
            this.lblTradeInValue = new System.Windows.Forms.Label();
            this.txtVehicleSalesPrice = new System.Windows.Forms.TextBox();
            this.txtTradeInValue = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gboxAccessories = new System.Windows.Forms.GroupBox();
            this.cboxComputerNavigation = new System.Windows.Forms.CheckBox();
            this.cboxStereoSystem = new System.Windows.Forms.CheckBox();
            this.cboxLeatherInterior = new System.Windows.Forms.CheckBox();
            this.gboxSummary = new System.Windows.Forms.GroupBox();
            this.lblTTradeIn = new System.Windows.Forms.Label();
            this.lblTTotal = new System.Windows.Forms.Label();
            this.lblTSalesTax = new System.Windows.Forms.Label();
            this.lblTSubtotal = new System.Windows.Forms.Label();
            this.lblTOptions = new System.Windows.Forms.Label();
            this.lblTVehicleSalesPrice = new System.Windows.Forms.Label();
            this.lblTAmountDue = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblTradeIn = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblVehiclesSalesPrice = new System.Windows.Forms.Label();
            this.gboxFinace = new System.Windows.Forms.GroupBox();
            this.lblTMonthlyPayment = new System.Windows.Forms.Label();
            this.nudAnnualInterestRate = new System.Windows.Forms.NumericUpDown();
            this.nudNoOfYears = new System.Windows.Forms.NumericUpDown();
            this.MonthlyPayment = new System.Windows.Forms.Label();
            this.lblAnnualInterestRate = new System.Windows.Forms.Label();
            this.lblNoOfYears = new System.Windows.Forms.Label();
            this.gboxExteriorFinish = new System.Windows.Forms.GroupBox();
            this.rbtnCustomizedDetailing = new System.Windows.Forms.RadioButton();
            this.rbtnStandard = new System.Windows.Forms.RadioButton();
            this.rbtnPearlized = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gboxAccessories.SuspendLayout();
            this.gboxSummary.SuspendLayout();
            this.gboxFinace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfYears)).BeginInit();
            this.gboxExteriorFinish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVehicleSalesPrice
            // 
            this.lblVehicleSalesPrice.AutoSize = true;
            this.lblVehicleSalesPrice.Location = new System.Drawing.Point(44, 35);
            this.lblVehicleSalesPrice.Name = "lblVehicleSalesPrice";
            this.lblVehicleSalesPrice.Size = new System.Drawing.Size(130, 16);
            this.lblVehicleSalesPrice.TabIndex = 0;
            this.lblVehicleSalesPrice.Text = "Vehicle\'s Sale Price:\r\n";
            // 
            // lblTradeInValue
            // 
            this.lblTradeInValue.AutoSize = true;
            this.lblTradeInValue.Location = new System.Drawing.Point(76, 68);
            this.lblTradeInValue.Name = "lblTradeInValue";
            this.lblTradeInValue.Size = new System.Drawing.Size(99, 16);
            this.lblTradeInValue.TabIndex = 1;
            this.lblTradeInValue.Text = "Trade-in Value:";
            // 
            // txtVehicleSalesPrice
            // 
            this.txtVehicleSalesPrice.Location = new System.Drawing.Point(194, 29);
            this.txtVehicleSalesPrice.Name = "txtVehicleSalesPrice";
            this.txtVehicleSalesPrice.Size = new System.Drawing.Size(145, 22);
            this.txtVehicleSalesPrice.TabIndex = 2;
            this.txtVehicleSalesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTradeInValue
            // 
            this.txtTradeInValue.Location = new System.Drawing.Point(194, 65);
            this.txtTradeInValue.Name = "txtTradeInValue";
            this.txtTradeInValue.Size = new System.Drawing.Size(145, 22);
            this.txtTradeInValue.TabIndex = 3;
            this.txtTradeInValue.Text = "0";
            this.txtTradeInValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(635, 477);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(113, 34);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Quote";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // gboxAccessories
            // 
            this.gboxAccessories.Controls.Add(this.cboxComputerNavigation);
            this.gboxAccessories.Controls.Add(this.cboxStereoSystem);
            this.gboxAccessories.Controls.Add(this.cboxLeatherInterior);
            this.gboxAccessories.Location = new System.Drawing.Point(47, 122);
            this.gboxAccessories.Name = "gboxAccessories";
            this.gboxAccessories.Size = new System.Drawing.Size(292, 150);
            this.gboxAccessories.TabIndex = 9;
            this.gboxAccessories.TabStop = false;
            this.gboxAccessories.Text = "Accessories";
            // 
            // cboxComputerNavigation
            // 
            this.cboxComputerNavigation.AutoSize = true;
            this.cboxComputerNavigation.Location = new System.Drawing.Point(32, 112);
            this.cboxComputerNavigation.Name = "cboxComputerNavigation";
            this.cboxComputerNavigation.Size = new System.Drawing.Size(155, 20);
            this.cboxComputerNavigation.TabIndex = 12;
            this.cboxComputerNavigation.Text = "Computer Navigation";
            this.cboxComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // cboxStereoSystem
            // 
            this.cboxStereoSystem.AutoSize = true;
            this.cboxStereoSystem.Location = new System.Drawing.Point(32, 30);
            this.cboxStereoSystem.Name = "cboxStereoSystem";
            this.cboxStereoSystem.Size = new System.Drawing.Size(117, 20);
            this.cboxStereoSystem.TabIndex = 10;
            this.cboxStereoSystem.Text = "Stereo System";
            this.cboxStereoSystem.UseVisualStyleBackColor = true;
            // 
            // cboxLeatherInterior
            // 
            this.cboxLeatherInterior.AutoSize = true;
            this.cboxLeatherInterior.Location = new System.Drawing.Point(32, 71);
            this.cboxLeatherInterior.Name = "cboxLeatherInterior";
            this.cboxLeatherInterior.Size = new System.Drawing.Size(117, 20);
            this.cboxLeatherInterior.TabIndex = 11;
            this.cboxLeatherInterior.Text = "Leather Interior";
            this.cboxLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // gboxSummary
            // 
            this.gboxSummary.Controls.Add(this.lblTTradeIn);
            this.gboxSummary.Controls.Add(this.lblTTotal);
            this.gboxSummary.Controls.Add(this.lblTSalesTax);
            this.gboxSummary.Controls.Add(this.lblTSubtotal);
            this.gboxSummary.Controls.Add(this.lblTOptions);
            this.gboxSummary.Controls.Add(this.lblTVehicleSalesPrice);
            this.gboxSummary.Controls.Add(this.lblTAmountDue);
            this.gboxSummary.Controls.Add(this.lblAmountDue);
            this.gboxSummary.Controls.Add(this.lblTradeIn);
            this.gboxSummary.Controls.Add(this.lblTotal);
            this.gboxSummary.Controls.Add(this.lblSalesTax);
            this.gboxSummary.Controls.Add(this.lblSubtotal);
            this.gboxSummary.Controls.Add(this.lblOptions);
            this.gboxSummary.Controls.Add(this.lblVehiclesSalesPrice);
            this.gboxSummary.Location = new System.Drawing.Point(375, 29);
            this.gboxSummary.Name = "gboxSummary";
            this.gboxSummary.Size = new System.Drawing.Size(373, 290);
            this.gboxSummary.TabIndex = 10;
            this.gboxSummary.TabStop = false;
            this.gboxSummary.Text = "Summary";
            // 
            // lblTTradeIn
            // 
            this.lblTTradeIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTTradeIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTTradeIn.Location = new System.Drawing.Point(190, 212);
            this.lblTTradeIn.Name = "lblTTradeIn";
            this.lblTTradeIn.Size = new System.Drawing.Size(152, 23);
            this.lblTTradeIn.TabIndex = 23;
            this.lblTTradeIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTTotal
            // 
            this.lblTTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTTotal.Location = new System.Drawing.Point(190, 175);
            this.lblTTotal.Name = "lblTTotal";
            this.lblTTotal.Size = new System.Drawing.Size(152, 23);
            this.lblTTotal.TabIndex = 22;
            this.lblTTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTSalesTax
            // 
            this.lblTSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTSalesTax.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTSalesTax.Location = new System.Drawing.Point(190, 136);
            this.lblTSalesTax.Name = "lblTSalesTax";
            this.lblTSalesTax.Size = new System.Drawing.Size(152, 23);
            this.lblTSalesTax.TabIndex = 21;
            this.lblTSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTSubtotal
            // 
            this.lblTSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTSubtotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTSubtotal.Location = new System.Drawing.Point(190, 98);
            this.lblTSubtotal.Name = "lblTSubtotal";
            this.lblTSubtotal.Size = new System.Drawing.Size(152, 23);
            this.lblTSubtotal.TabIndex = 20;
            this.lblTSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTOptions
            // 
            this.lblTOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTOptions.Location = new System.Drawing.Point(190, 63);
            this.lblTOptions.Name = "lblTOptions";
            this.lblTOptions.Size = new System.Drawing.Size(152, 23);
            this.lblTOptions.TabIndex = 19;
            this.lblTOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTVehicleSalesPrice
            // 
            this.lblTVehicleSalesPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTVehicleSalesPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTVehicleSalesPrice.Location = new System.Drawing.Point(190, 29);
            this.lblTVehicleSalesPrice.Name = "lblTVehicleSalesPrice";
            this.lblTVehicleSalesPrice.Size = new System.Drawing.Size(152, 23);
            this.lblTVehicleSalesPrice.TabIndex = 18;
            this.lblTVehicleSalesPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTAmountDue
            // 
            this.lblTAmountDue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTAmountDue.Location = new System.Drawing.Point(190, 241);
            this.lblTAmountDue.Name = "lblTAmountDue";
            this.lblTAmountDue.Size = new System.Drawing.Size(152, 23);
            this.lblTAmountDue.TabIndex = 14;
            this.lblTAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(92, 248);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(83, 16);
            this.lblAmountDue.TabIndex = 6;
            this.lblAmountDue.Text = "Amount Due:";
            // 
            // lblTradeIn
            // 
            this.lblTradeIn.AutoSize = true;
            this.lblTradeIn.Location = new System.Drawing.Point(114, 212);
            this.lblTradeIn.Name = "lblTradeIn";
            this.lblTradeIn.Size = new System.Drawing.Size(61, 16);
            this.lblTradeIn.TabIndex = 5;
            this.lblTradeIn.Text = "Trade-In:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(134, 175);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 16);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(67, 133);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(108, 16);
            this.lblSalesTax.TabIndex = 3;
            this.lblSalesTax.Text = "Sales Tax (12%):";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(116, 96);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(59, 16);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(119, 62);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(56, 16);
            this.lblOptions.TabIndex = 1;
            this.lblOptions.Text = "Options:";
            // 
            // lblVehiclesSalesPrice
            // 
            this.lblVehiclesSalesPrice.AutoSize = true;
            this.lblVehiclesSalesPrice.Location = new System.Drawing.Point(38, 29);
            this.lblVehiclesSalesPrice.Name = "lblVehiclesSalesPrice";
            this.lblVehiclesSalesPrice.Size = new System.Drawing.Size(137, 16);
            this.lblVehiclesSalesPrice.TabIndex = 0;
            this.lblVehiclesSalesPrice.Text = "Vehicle\'s Sales Price:";
            // 
            // gboxFinace
            // 
            this.gboxFinace.Controls.Add(this.lblTMonthlyPayment);
            this.gboxFinace.Controls.Add(this.nudAnnualInterestRate);
            this.gboxFinace.Controls.Add(this.nudNoOfYears);
            this.gboxFinace.Controls.Add(this.MonthlyPayment);
            this.gboxFinace.Controls.Add(this.lblAnnualInterestRate);
            this.gboxFinace.Controls.Add(this.lblNoOfYears);
            this.gboxFinace.Location = new System.Drawing.Point(375, 325);
            this.gboxFinace.Name = "gboxFinace";
            this.gboxFinace.Size = new System.Drawing.Size(373, 129);
            this.gboxFinace.TabIndex = 11;
            this.gboxFinace.TabStop = false;
            this.gboxFinace.Text = "Finance";
            // 
            // lblTMonthlyPayment
            // 
            this.lblTMonthlyPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTMonthlyPayment.Location = new System.Drawing.Point(246, 68);
            this.lblTMonthlyPayment.Name = "lblTMonthlyPayment";
            this.lblTMonthlyPayment.Size = new System.Drawing.Size(106, 23);
            this.lblTMonthlyPayment.TabIndex = 5;
            this.lblTMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudAnnualInterestRate
            // 
            this.nudAnnualInterestRate.DecimalPlaces = 2;
            this.nudAnnualInterestRate.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nudAnnualInterestRate.Location = new System.Drawing.Point(137, 69);
            this.nudAnnualInterestRate.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAnnualInterestRate.Name = "nudAnnualInterestRate";
            this.nudAnnualInterestRate.Size = new System.Drawing.Size(79, 22);
            this.nudAnnualInterestRate.TabIndex = 4;
            this.nudAnnualInterestRate.Value = new decimal(new int[] {
            500,
            0,
            0,
            131072});
            // 
            // nudNoOfYears
            // 
            this.nudNoOfYears.Location = new System.Drawing.Point(30, 70);
            this.nudNoOfYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNoOfYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoOfYears.Name = "nudNoOfYears";
            this.nudNoOfYears.Size = new System.Drawing.Size(78, 22);
            this.nudNoOfYears.TabIndex = 3;
            this.nudNoOfYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MonthlyPayment
            // 
            this.MonthlyPayment.AutoSize = true;
            this.MonthlyPayment.Location = new System.Drawing.Point(243, 36);
            this.MonthlyPayment.Name = "MonthlyPayment";
            this.MonthlyPayment.Size = new System.Drawing.Size(109, 16);
            this.MonthlyPayment.TabIndex = 2;
            this.MonthlyPayment.Text = "Monthly Payment";
            // 
            // lblAnnualInterestRate
            // 
            this.lblAnnualInterestRate.AutoSize = true;
            this.lblAnnualInterestRate.Location = new System.Drawing.Point(134, 18);
            this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
            this.lblAnnualInterestRate.Size = new System.Drawing.Size(82, 48);
            this.lblAnnualInterestRate.TabIndex = 1;
            this.lblAnnualInterestRate.Text = "Annual\r\nInterest Rate\r\n\r\n";
            // 
            // lblNoOfYears
            // 
            this.lblNoOfYears.AutoSize = true;
            this.lblNoOfYears.Location = new System.Drawing.Point(27, 36);
            this.lblNoOfYears.Name = "lblNoOfYears";
            this.lblNoOfYears.Size = new System.Drawing.Size(81, 16);
            this.lblNoOfYears.TabIndex = 0;
            this.lblNoOfYears.Text = "No. of Years";
            // 
            // gboxExteriorFinish
            // 
            this.gboxExteriorFinish.Controls.Add(this.rbtnCustomizedDetailing);
            this.gboxExteriorFinish.Controls.Add(this.rbtnStandard);
            this.gboxExteriorFinish.Controls.Add(this.rbtnPearlized);
            this.gboxExteriorFinish.Location = new System.Drawing.Point(47, 289);
            this.gboxExteriorFinish.Name = "gboxExteriorFinish";
            this.gboxExteriorFinish.Size = new System.Drawing.Size(292, 165);
            this.gboxExteriorFinish.TabIndex = 12;
            this.gboxExteriorFinish.TabStop = false;
            this.gboxExteriorFinish.Text = "Exterior Finish";
            // 
            // rbtnCustomizedDetailing
            // 
            this.rbtnCustomizedDetailing.AutoSize = true;
            this.rbtnCustomizedDetailing.Location = new System.Drawing.Point(32, 108);
            this.rbtnCustomizedDetailing.Name = "rbtnCustomizedDetailing";
            this.rbtnCustomizedDetailing.Size = new System.Drawing.Size(151, 20);
            this.rbtnCustomizedDetailing.TabIndex = 15;
            this.rbtnCustomizedDetailing.TabStop = true;
            this.rbtnCustomizedDetailing.Text = "Cusomized Detailing";
            this.rbtnCustomizedDetailing.UseVisualStyleBackColor = true;
            // 
            // rbtnStandard
            // 
            this.rbtnStandard.AutoSize = true;
            this.rbtnStandard.Checked = true;
            this.rbtnStandard.Location = new System.Drawing.Point(32, 36);
            this.rbtnStandard.Name = "rbtnStandard";
            this.rbtnStandard.Size = new System.Drawing.Size(83, 20);
            this.rbtnStandard.TabIndex = 13;
            this.rbtnStandard.TabStop = true;
            this.rbtnStandard.Text = "Standard";
            this.rbtnStandard.UseVisualStyleBackColor = true;
            this.rbtnStandard.UseWaitCursor = true;
            // 
            // rbtnPearlized
            // 
            this.rbtnPearlized.AutoSize = true;
            this.rbtnPearlized.Location = new System.Drawing.Point(32, 72);
            this.rbtnPearlized.Name = "rbtnPearlized";
            this.rbtnPearlized.Size = new System.Drawing.Size(85, 20);
            this.rbtnPearlized.TabIndex = 14;
            this.rbtnPearlized.TabStop = true;
            this.rbtnPearlized.Text = "Pearlized";
            this.rbtnPearlized.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(47, 477);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 34);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // SalesQuoteForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(792, 527);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gboxExteriorFinish);
            this.Controls.Add(this.gboxFinace);
            this.Controls.Add(this.gboxSummary);
            this.Controls.Add(this.gboxAccessories);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTradeInValue);
            this.Controls.Add(this.txtVehicleSalesPrice);
            this.Controls.Add(this.lblTradeInValue);
            this.Controls.Add(this.lblVehicleSalesPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SalesQuoteForm";
            this.Text = "Vehicle Sales Quote";
            this.gboxAccessories.ResumeLayout(false);
            this.gboxAccessories.PerformLayout();
            this.gboxSummary.ResumeLayout(false);
            this.gboxSummary.PerformLayout();
            this.gboxFinace.ResumeLayout(false);
            this.gboxFinace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfYears)).EndInit();
            this.gboxExteriorFinish.ResumeLayout(false);
            this.gboxExteriorFinish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehicleSalesPrice;
        private System.Windows.Forms.Label lblTradeInValue;
        private System.Windows.Forms.TextBox txtVehicleSalesPrice;
        private System.Windows.Forms.TextBox txtTradeInValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox gboxAccessories;
        private System.Windows.Forms.CheckBox cboxStereoSystem;
        private System.Windows.Forms.CheckBox cboxComputerNavigation;
        private System.Windows.Forms.CheckBox cboxLeatherInterior;
        private System.Windows.Forms.GroupBox gboxSummary;
        private System.Windows.Forms.GroupBox gboxFinace;
        private System.Windows.Forms.GroupBox gboxExteriorFinish;
        private System.Windows.Forms.RadioButton rbtnCustomizedDetailing;
        private System.Windows.Forms.RadioButton rbtnStandard;
        private System.Windows.Forms.RadioButton rbtnPearlized;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblTradeIn;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblVehiclesSalesPrice;
        private System.Windows.Forms.NumericUpDown nudAnnualInterestRate;
        private System.Windows.Forms.NumericUpDown nudNoOfYears;
        private System.Windows.Forms.Label MonthlyPayment;
        private System.Windows.Forms.Label lblAnnualInterestRate;
        private System.Windows.Forms.Label lblNoOfYears;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTAmountDue;
        private System.Windows.Forms.Label lblTMonthlyPayment;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblTTradeIn;
        private System.Windows.Forms.Label lblTTotal;
        private System.Windows.Forms.Label lblTSalesTax;
        private System.Windows.Forms.Label lblTSubtotal;
        private System.Windows.Forms.Label lblTOptions;
        private System.Windows.Forms.Label lblTVehicleSalesPrice;
    }
}