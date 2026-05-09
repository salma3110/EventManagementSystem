namespace EventManagementApp
{
    partial class VenueForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textVenueName = new System.Windows.Forms.TextBox();
            this.textStreet = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textCapacity = new System.Windows.Forms.TextBox();
            this.btnSaveVenue = new System.Windows.Forms.Button();
            this.btnClearVenue = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dvgVenues1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVenues1)).BeginInit();
            this.SuspendLayout();

            // label6 - Venue Name
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 38);
            this.label6.Name = "label6";
            this.label6.Text = "Venue Name";

            // label7 - Street Name
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 87);
            this.label7.Name = "label7";
            this.label7.Text = "Street Name";

            // label8 - City
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 141);
            this.label8.Name = "label8";
            this.label8.Text = "City";

            // label9 - Capacity
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 201);
            this.label9.Name = "label9";
            this.label9.Text = "Capacity";

            // textVenueName
            this.textVenueName.Location = new System.Drawing.Point(213, 38);
            this.textVenueName.Name = "textVenueName";
            this.textVenueName.Size = new System.Drawing.Size(200, 22);

            // textStreet
            this.textStreet.Location = new System.Drawing.Point(213, 87);
            this.textStreet.Name = "textStreet";
            this.textStreet.Size = new System.Drawing.Size(200, 22);

            // textCity
            this.textCity.Location = new System.Drawing.Point(213, 141);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(200, 22);

            // textCapacity
            this.textCapacity.Location = new System.Drawing.Point(213, 194);
            this.textCapacity.Name = "textCapacity";
            this.textCapacity.Size = new System.Drawing.Size(200, 22);

            // btnSaveVenue
            this.btnSaveVenue.Location = new System.Drawing.Point(65, 260);
            this.btnSaveVenue.Name = "btnSaveVenue";
            this.btnSaveVenue.Size = new System.Drawing.Size(120, 30);
            this.btnSaveVenue.Text = "Save Venue";
            this.btnSaveVenue.Click += new System.EventHandler(this.btnSaveVenue_Click);

            // btnClearVenue
            this.btnClearVenue.Location = new System.Drawing.Point(213, 260);
            this.btnClearVenue.Name = "btnClearVenue";
            this.btnClearVenue.Size = new System.Drawing.Size(100, 30);
            this.btnClearVenue.Text = "Clear";
            this.btnClearVenue.Click += new System.EventHandler(this.btnClearVenue_Click);

            // label10 - Existing Venues
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 320);
            this.label10.Name = "label10";
            this.label10.Text = "Existing Venues";

            // dvgVenues1
            this.dvgVenues1.Location = new System.Drawing.Point(65, 345);
            this.dvgVenues1.Name = "dvgVenues1";
            this.dvgVenues1.Size = new System.Drawing.Size(500, 150);
            this.dvgVenues1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVenues1.RowTemplate.Height = 24;

            // VenueForm
            this.ClientSize = new System.Drawing.Size(620, 530);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textVenueName);
            this.Controls.Add(this.textStreet);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textCapacity);
            this.Controls.Add(this.btnSaveVenue);
            this.Controls.Add(this.btnClearVenue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dvgVenues1);
            this.Name = "VenueForm";
            this.Text = "Manage Venues";
            this.Load += new System.EventHandler(this.VenueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgVenues1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ONLY the controls that actually exist
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textVenueName;
        private System.Windows.Forms.TextBox textStreet;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textCapacity;
        private System.Windows.Forms.Button btnSaveVenue;
        private System.Windows.Forms.Button btnClearVenue;
        private System.Windows.Forms.DataGridView dvgVenues1;
    }
}