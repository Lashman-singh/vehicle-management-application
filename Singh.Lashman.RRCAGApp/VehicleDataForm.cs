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
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Collections;

namespace Singh.Lashman.RRCAGApp
{
    // Class declaration for VehicleDataForm
    public partial class VehicleDataForm : ACE.BIT.ADEV.Forms.VehicleDataForm
    {
        private const string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AMDatabase.mdb";
        private const string TableName = "VehicleStock";
        private bool changes = false;
        private VehicleDataForm vehicleData;

        // Constructor for the VehicleDataForm
        public VehicleDataForm()
        {
            InitializeComponent();
            InitialState();
            this.mnuFileSave.Click += MnuFileSave_Click;
            this.mnuFileClose.Click += MnuFileClose_Click;
            this.dgvVehicles.SelectionChanged += DataGridViewSelectionChanged;
            this.dgvVehicles.CellContextMenuStripChanged += DgvVehicles_CellValueChanged;
            this.mnuEditRemove.Click += MnuEditRemove_Click;
            this.FormClosing += VehicleDataForm_FormClosing;
            this.FormClosing += MainForm_FormClosing;
        }

        // Event handler for the MainForm_FormClosing event
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the Vehicle Data Form is open and has unsaved changes
            if (vehicleData != null && vehicleData.changes)
            {
                // Attempt to save changes
                vehicleData.SaveChanges();
            }
        }

        // Event handler for the VehicleDataForm_FormClosing event
        private void VehicleDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes)
            {
                string text = "Do you wish to save the changes?";
                string caption = "Save";
                DialogResult result = MessageBox.Show(text, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);

                if (result == DialogResult.Yes)
                {
                    // Attempt to save changes
                    try
                    {
                        SaveChanges();
                    }
                    catch
                    {
                        // Show error message and prevent the form from closing
                        text = "An error occurred while saving the changes. Do you still wish to close?";
                        caption = "Save Error";
                        result = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);

                        if (result == DialogResult.No)
                        {
                            e.Cancel = true; // Prevent form from closing
                        }
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true; // Prevent form from closing
                }
            }
        }

        // Method to save changes to the database
        private void SaveChanges()
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                foreach (DataGridViewRow row in dgvVehicles.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        // Implement your logic to save changes to the database
                        int stockNumber = Convert.ToInt32(row.Cells["StockNumber"].Value);
                    }
                }

                // Reset the changes flag
                changes = false;
                this.Text = "Vehicle Data";
                this.mnuFileSave.Enabled = false;
            }
        }

        // Event handler for the MnuFileSave_Click event
        private void MnuFileSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveChanges();
            }
            catch (Exception ex)
            {
                string text = "An error occurred while saving the changes to the vehicle data.";
                string caption = "Save error";
                MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update the existing event handlers to set the 'changes' flag when data is modified
        private void DgvVehicles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changes = true;
            this.Text = "* Vehicle Data";
            this.mnuFileSave.Enabled = true;
        }

        // Event handler for the DataGridViewSelectionChanged event
        private void DataGridViewSelectionChanged(object sender, EventArgs e)
        {
            if (dgvVehicles.CurrentRow != null && !dgvVehicles.CurrentRow.IsNewRow && dgvVehicles.SelectedCells.Count == dgvVehicles.Columns.Count)
            {
                // Enable the Remove menu item if a non-new row is selected
                this.mnuEditRemove.Enabled = true;
            }
            else
            {
                // Disable the Remove menu item if no row is selected or a new row is selected
                this.mnuEditRemove.Enabled = false;
            }
        }

        // Event handler for the MnuEditRemove_Click event
        private void MnuEditRemove_Click(object sender, EventArgs e)
        {
            if(dgvVehicles.CurrentRow != null && !dgvVehicles.CurrentRow.IsNewRow)
            {
                string text = $"Remove stock item {dgvVehicles.CurrentRow.Cells["StockNumber"].Value}?"; 
                string caption = "Remove Stock Item";
                DialogResult result = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    dgvVehicles.Rows.Remove(dgvVehicles.CurrentRow);
                    changes = true;
                    this.Text = "* Vehicle Data";
                    this.mnuFileSave.Enabled = true;
                }
            }
        }

        // Method to set the initial state of the form
        public void InitialState()
        {
            this.mnuFileSave.Enabled = false;
            this.mnuFileClose.Enabled = false;
            this.mnuEditRemove.Enabled = false;
            this.Text = "Vehicle Data";
            this.WindowState = FormWindowState.Maximized;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AllowUserToResizeRows = false;
            dgvVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataRetrieving();
        }

        // Event handler for the MnuFileClose_Click event
        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Method to retrieve and bind data during form initialization
        public void DataRetrieving()
        {
            try
            { 
                // Attempt to retrieve and bind data during form initialization
                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    connection.Open();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter($"SELECT * FROM {TableName}", connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Display the vehicle data in the DataGridView
                        dgvVehicles.DataSource = dataTable;

                        // Hide the "ID" and "SoldBy" columns
                        dgvVehicles.Columns["ID"].Visible = false;
                        dgvVehicles.Columns["SoldBy"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Show error message and prevent the form from being displayed
                MessageBox.Show($"Unable to load vehicle data.\n\nDetails: {ex.Message}", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
