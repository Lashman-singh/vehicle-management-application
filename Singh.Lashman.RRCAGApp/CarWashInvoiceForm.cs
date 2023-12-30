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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACE.BIT.ADEV.CarWash;
using ACE.BIT.ADEV.Forms;
using Singh.Lashman.Business;

namespace Singh.Lashman.RRCAGApp
{
    public partial class CarWashInvoiceForm : ACE.BIT.ADEV.Forms.CarWashInvoiceForm
    {
        private BindingSource bindingSource;
        public CarWashInvoiceForm(BindingSource bindingSource)
        {
            InitializeComponent();
            this.bindingSource = bindingSource;
            this.Load += CarWashInvoiceForm_Load;
            InitializeItems();
        }

        /// <summary>
        /// Handles the initial state of the form.
        /// </summary>
        private void CarWashInvoiceForm_Load(object sender, System.EventArgs e)
        {
            this.Text = "Car Wash Invoice";
            BindControls();
        }

        private void BindControls()
        {
            Binding fragrancePriceBind = new Binding("Text", this.bindingSource, "FragranceCost");
            this.lblFragrancePrice.DataBindings.Add(fragrancePriceBind);

            Binding packagePriceBind = new Binding("Text", this.bindingSource, "PackageCost", true);
            packagePriceBind.FormatString = "C";
            this.lblPackagePrice.DataBindings.Add(packagePriceBind);

            Binding subTotalBind = new Binding("Text", this.bindingSource, "SubTotal", true);
            subTotalBind.FormatString = "C";
            this.lblSubtotal.DataBindings.Add(subTotalBind);

            Binding pstBind = new Binding("Text", this.bindingSource, "ProvincialSalesTaxCharged");
            this.lblProvincialSalesTax.DataBindings.Add(pstBind);

            Binding gstBind = new Binding("Text", this.bindingSource, "GoodsAndServicesTaxCharged");
            this.lblGoodsAndServicesTax.DataBindings.Add(gstBind);

            Binding totalBind = new Binding("Text", this.bindingSource, "Total", true);
            totalBind.FormatString = "C";
            this.lblTotal.DataBindings.Add(totalBind);
        }

        private void InitializeItems()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(619, 393);
            this.Name = "CarWashInvoiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
