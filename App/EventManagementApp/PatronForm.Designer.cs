namespace EventManagementApp
{
    partial class PatronForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvPatrons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrons)).BeginInit();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 45);
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 95);
            this.label2.Text = "Last Name";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 144);
            this.label3.Text = "Email";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 186);
            this.label4.Text = "Phone Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);

            this.txtFname.Location = new System.Drawing.Point(286, 45);
            this.txtFname.Size = new System.Drawing.Size(167, 22);

            this.txtLname.Location = new System.Drawing.Point(286, 89);
            this.txtLname.Size = new System.Drawing.Size(167, 22);

            this.txtEmail.Location = new System.Drawing.Point(286, 141);
            this.txtEmail.Size = new System.Drawing.Size(167, 22);

            this.txtPhone.Location = new System.Drawing.Point(286, 180);
            this.txtPhone.Size = new System.Drawing.Size(167, 22);

            this.btnRegister.Location = new System.Drawing.Point(89, 240);
            this.btnRegister.Size = new System.Drawing.Size(128, 32);
            this.btnRegister.Text = "Register Patron";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            this.btnUpdate.Location = new System.Drawing.Point(240, 240);
            this.btnUpdate.Size = new System.Drawing.Size(120, 32);
            this.btnUpdate.Text = "Update Phone";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Location = new System.Drawing.Point(380, 240);
            this.btnDelete.Size = new System.Drawing.Size(100, 32);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.dgvPatrons.Location = new System.Drawing.Point(89, 300);
            this.dgvPatrons.Size = new System.Drawing.Size(600, 160);
            this.dgvPatrons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatrons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvPatrons);
            this.Name = "PatronForm";
            this.Text = "Manage Patrons";
            this.Load += new System.EventHandler(this.PatronForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvPatrons;
    }
}