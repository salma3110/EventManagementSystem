namespace EventManagementApp
{
    partial class EntryPassForm
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
            this.lblSeats = new System.Windows.Forms.Label();
            this.cmbPatron = new System.Windows.Forms.ComboBox();
            this.cmbGathering = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvPasses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasses)).BeginInit();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 40);
            this.label1.Name = "label1";
            this.label1.Text = "Patron";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 90);
            this.label2.Name = "label2";
            this.label2.Text = "Gathering";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 140);
            this.label3.Name = "label3";
            this.label3.Text = "Entry Class";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 260);
            this.label4.Name = "label4";
            this.label4.Text = "Existing Passes";

            this.lblSeats.AutoSize = true;
            this.lblSeats.Location = new System.Drawing.Point(470, 140);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Text = "";
            this.lblSeats.ForeColor = System.Drawing.Color.DarkGreen;

            this.cmbPatron.Location = new System.Drawing.Point(200, 37);
            this.cmbPatron.Name = "cmbPatron";
            this.cmbPatron.Size = new System.Drawing.Size(250, 22);
            this.cmbPatron.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbGathering.Location = new System.Drawing.Point(200, 87);
            this.cmbGathering.Name = "cmbGathering";
            this.cmbGathering.Size = new System.Drawing.Size(250, 22);
            this.cmbGathering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbClass.Location = new System.Drawing.Point(200, 137);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(250, 22);
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.btnPurchase.Location = new System.Drawing.Point(65, 195);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(130, 30);
            this.btnPurchase.Text = "Purchase Pass";
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);

            this.btnClear.Location = new System.Drawing.Point(220, 195);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.dgvPasses.Location = new System.Drawing.Point(65, 285);
            this.dgvPasses.Name = "dgvPasses";
            this.dgvPasses.Size = new System.Drawing.Size(650, 150);
            this.dgvPasses.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasses.RowTemplate.Height = 24;
            this.dgvPasses.ReadOnly = true;

            this.ClientSize = new System.Drawing.Size(780, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.cmbPatron);
            this.Controls.Add(this.cmbGathering);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvPasses);
            this.Name = "EntryPassForm";
            this.Text = "Purchase Entry Pass";
            this.Load += new System.EventHandler(this.EntryPassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.ComboBox cmbPatron;
        private System.Windows.Forms.ComboBox cmbGathering;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvPasses;
    }
}