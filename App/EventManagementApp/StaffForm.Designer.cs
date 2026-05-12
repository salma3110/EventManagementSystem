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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.cmbGathering = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnSaveStaff = new System.Windows.Forms.Button();
            this.btnClearStaff = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.SuspendLayout();

            // ── SECTION 1: Add Staff ──
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Text = "── Add New Staff ──";
            this.label1.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Text = "First Name";

            this.txtFname.Location = new System.Drawing.Point(150, 50);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(180, 22);

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 85);
            this.label3.Text = "Last Name";

            this.txtLname.Location = new System.Drawing.Point(150, 85);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(180, 22);

            this.btnSaveStaff.Location = new System.Drawing.Point(20, 120);
            this.btnSaveStaff.Name = "btnSaveStaff";
            this.btnSaveStaff.Size = new System.Drawing.Size(120, 28);
            this.btnSaveStaff.Text = "Save Staff";
            this.btnSaveStaff.Click += new System.EventHandler(this.btnSaveStaff_Click);

            this.btnClearStaff.Location = new System.Drawing.Point(160, 120);
            this.btnClearStaff.Name = "btnClearStaff";
            this.btnClearStaff.Size = new System.Drawing.Size(80, 28);
            this.btnClearStaff.Text = "Clear";
            this.btnClearStaff.Click += new System.EventHandler(this.btnClearStaff_Click);

            this.dgvStaff.Location = new System.Drawing.Point(20, 165);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(380, 100);
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.ReadOnly = true;

            // ── SECTION 2: Assign Staff to Gathering ──
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 285);
            this.label4.Text = "── Assign Staff to Gathering ──";
            this.label4.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 315);
            this.label5.Text = "Staff Member";

            this.cmbStaff.Location = new System.Drawing.Point(150, 315);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(250, 22);
            this.cmbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 355);
            this.label6.Text = "Gathering";

            this.cmbGathering.Location = new System.Drawing.Point(150, 355);
            this.cmbGathering.Name = "cmbGathering";
            this.cmbGathering.Size = new System.Drawing.Size(250, 22);
            this.cmbGathering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Role label
            System.Windows.Forms.Label lblRole = new System.Windows.Forms.Label();
            lblRole.AutoSize = true;
            lblRole.Location = new System.Drawing.Point(20, 395);
            lblRole.Text = "Role";
            this.Controls.Add(lblRole);

            this.cmbRole.Location = new System.Drawing.Point(150, 395);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(250, 22);
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.Add("Coordinator");
            this.cmbRole.Items.Add("Primary Technician");
            this.cmbRole.Items.Add("Staff");

            this.btnAssign.Location = new System.Drawing.Point(20, 435);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(150, 28);
            this.btnAssign.Text = "Assign to Gathering";
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);

            this.dgvAssignments.Location = new System.Drawing.Point(20, 475);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.Size = new System.Drawing.Size(700, 130);
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignments.RowTemplate.Height = 24;
            this.dgvAssignments.ReadOnly = true;

            // StaffForm
            this.ClientSize = new System.Drawing.Size(750, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.btnSaveStaff);
            this.Controls.Add(this.btnClearStaff);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.cmbStaff);
            this.Controls.Add(this.cmbGathering);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.dgvAssignments);
            this.Name = "StaffForm";
            this.Text = "Manage Staff & Assignments";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.ComboBox cmbGathering;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnSaveStaff;
        private System.Windows.Forms.Button btnClearStaff;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.DataGridView dgvAssignments;
    }
}