namespace EventManagementApp
{
    partial class StaffForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.btnSaveStaff = new System.Windows.Forms.Button();
            this.btnClearStaff = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();

            // label1 - First Name
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 40);
            this.label1.Name = "label1";
            this.label1.Text = "First Name";

            // label2 - Last Name
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 90);
            this.label2.Name = "label2";
            this.label2.Text = "Last Name";

            // label3 - Existing Staff
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 200);
            this.label3.Name = "label3";
            this.label3.Text = "Existing Staff";

            // txtFname
            this.txtFname.Location = new System.Drawing.Point(200, 40);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(200, 22);

            // txtLname
            this.txtLname.Location = new System.Drawing.Point(200, 90);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(200, 22);

            // btnSaveStaff
            this.btnSaveStaff.Location = new System.Drawing.Point(65, 140);
            this.btnSaveStaff.Name = "btnSaveStaff";
            this.btnSaveStaff.Size = new System.Drawing.Size(120, 30);
            this.btnSaveStaff.Text = "Save Staff";
            this.btnSaveStaff.Click += new System.EventHandler(this.btnSaveStaff_Click);

            // btnClearStaff
            this.btnClearStaff.Location = new System.Drawing.Point(210, 140);
            this.btnClearStaff.Name = "btnClearStaff";
            this.btnClearStaff.Size = new System.Drawing.Size(100, 30);
            this.btnClearStaff.Text = "Clear";
            this.btnClearStaff.Click += new System.EventHandler(this.btnClearStaff_Click);

            // dgvStaff
            this.dgvStaff.Location = new System.Drawing.Point(65, 225);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(500, 150);
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.RowTemplate.Height = 24;

            // StaffForm
            this.ClientSize = new System.Drawing.Size(620, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.btnSaveStaff);
            this.Controls.Add(this.btnClearStaff);
            this.Controls.Add(this.dgvStaff);
            this.Name = "StaffForm";
            this.Text = "Manage Staff";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Button btnSaveStaff;
        private System.Windows.Forms.Button btnClearStaff;
        private System.Windows.Forms.DataGridView dgvStaff;
    }
}