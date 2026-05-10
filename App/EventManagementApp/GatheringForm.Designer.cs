namespace EventManagementApp
{
    partial class GatheringForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbVenue = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvGatherings = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGatherings)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(50, 40);
            this.lblTitle.Text = "Title";

            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(50, 90);
            this.lblDate.Text = "Date";

            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(50, 140);
            this.lblCategory.Text = "Category";

            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(50, 190);
            this.lblVenue.Text = "Venue";

            this.txtTitle.Location = new System.Drawing.Point(200, 37);
            this.txtTitle.Size = new System.Drawing.Size(250, 22);

            this.dtpDate.Location = new System.Drawing.Point(200, 87);
            this.dtpDate.Size = new System.Drawing.Size(250, 22);

            this.txtCategory.Location = new System.Drawing.Point(200, 137);
            this.txtCategory.Size = new System.Drawing.Size(250, 22);

            this.cmbVenue.Location = new System.Drawing.Point(200, 187);
            this.cmbVenue.Size = new System.Drawing.Size(250, 22);

            this.btnSave.Location = new System.Drawing.Point(50, 240);
            this.btnSave.Size = new System.Drawing.Size(130, 32);
            this.btnSave.Text = "Save Gathering";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnUpdate.Location = new System.Drawing.Point(200, 240);
            this.btnUpdate.Size = new System.Drawing.Size(130, 32);
            this.btnUpdate.Text = "Update Category";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Location = new System.Drawing.Point(350, 240);
            this.btnDelete.Size = new System.Drawing.Size(100, 32);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.dgvGatherings.Location = new System.Drawing.Point(50, 300);
            this.dgvGatherings.Size = new System.Drawing.Size(700, 160);
            this.dgvGatherings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGatherings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.cmbVenue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvGatherings);
            this.Name = "GatheringForm";
            this.Text = "Manage Gatherings";
            this.Load += new System.EventHandler(this.GatheringForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGatherings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbVenue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvGatherings;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblVenue;
    }
}