namespace EventManagementApp
{
    partial class Form1
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
            this.btnPatron = new System.Windows.Forms.Button();
            this.btnGathering = new System.Windows.Forms.Button();
            this.btnEntryClass = new System.Windows.Forms.Button();
            this.btnEntryPass = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPatron
            // 
            this.btnPatron.Location = new System.Drawing.Point(36, 167);
            this.btnPatron.Name = "btnPatron";
            this.btnPatron.Size = new System.Drawing.Size(150, 35);
            this.btnPatron.TabIndex = 0;
            this.btnPatron.Text = "Manage Patron";
            this.btnPatron.UseVisualStyleBackColor = true;
            this.btnPatron.Click += new System.EventHandler(this.btnPatron_Click);
            // 
            // btnGathering
            // 
            this.btnGathering.Location = new System.Drawing.Point(221, 167);
            this.btnGathering.Name = "btnGathering";
            this.btnGathering.Size = new System.Drawing.Size(150, 35);
            this.btnGathering.TabIndex = 1;
            this.btnGathering.Text = "Manage Gatherings";
            this.btnGathering.UseVisualStyleBackColor = true;
            this.btnGathering.Click += new System.EventHandler(this.btnGathering_Click);
            // 
            // btnEntryClass
            // 
            this.btnEntryClass.Location = new System.Drawing.Point(410, 167);
            this.btnEntryClass.Name = "btnEntryClass";
            this.btnEntryClass.Size = new System.Drawing.Size(150, 35);
            this.btnEntryClass.TabIndex = 2;
            this.btnEntryClass.Text = "Entry Classes";
            this.btnEntryClass.UseVisualStyleBackColor = true;
            this.btnEntryClass.Click += new System.EventHandler(this.btnEntryClass_Click);
            // 
            // btnEntryPass
            // 
            this.btnEntryPass.Location = new System.Drawing.Point(36, 254);
            this.btnEntryPass.Name = "btnEntryPass";
            this.btnEntryPass.Size = new System.Drawing.Size(150, 35);
            this.btnEntryPass.TabIndex = 3;
            this.btnEntryPass.Text = "Purchase Pass";
            this.btnEntryPass.UseVisualStyleBackColor = true;
            this.btnEntryPass.Click += new System.EventHandler(this.btnEntryPass_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(221, 254);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(150, 35);
            this.btnStaff.TabIndex = 4;
            this.btnStaff.Text = "Assign Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(410, 254);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(150, 35);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "View Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnEntryPass);
            this.Controls.Add(this.btnEntryClass);
            this.Controls.Add(this.btnGathering);
            this.Controls.Add(this.btnPatron);
            this.Name = "Form1";
            this.Text = "Event Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPatron;
        private System.Windows.Forms.Button btnGathering;
        private System.Windows.Forms.Button btnEntryClass;
        private System.Windows.Forms.Button btnEntryPass;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnReports;
    }
}

