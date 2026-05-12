namespace EventManagementApp
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.dgvSeats = new System.Windows.Forms.DataGridView();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();

            // Title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(50, 15);
            this.lblTitle.Text = "Tracking Seat Availability and Gathering Schedules";

            // Seat availability label
            this.lblSeats.AutoSize = true;
            this.lblSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F,
                System.Drawing.FontStyle.Bold);
            this.lblSeats.Location = new System.Drawing.Point(50, 55);
            this.lblSeats.Text = "Seat Availability";

            // Seat availability grid
            this.dgvSeats.Location = new System.Drawing.Point(50, 78);
            this.dgvSeats.Size = new System.Drawing.Size(880, 200);
            this.dgvSeats.ReadOnly = true;
            this.dgvSeats.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeats.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeats.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Schedule label
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F,
                System.Drawing.FontStyle.Bold);
            this.lblSchedule.Location = new System.Drawing.Point(50, 300);
            this.lblSchedule.Text = "Gathering Schedule";

            // Schedule grid
            this.dgvSchedule.Location = new System.Drawing.Point(50, 323);
            this.dgvSchedule.Size = new System.Drawing.Size(880, 200);
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 560);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.dgvSeats);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.dgvSchedule);
            this.Name = "ReportsForm";
            this.Text = "View Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.DataGridView dgvSeats;
        private System.Windows.Forms.DataGridView dgvSchedule;
    }
}