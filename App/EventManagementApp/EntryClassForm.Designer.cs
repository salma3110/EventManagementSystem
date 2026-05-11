namespace EventManagementApp
{
    partial class EntryClassForm
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.dgvEntryClass = new System.Windows.Forms.DataGridView();
            this.eventManagementDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventManagementDBDataSet = new EventManagementApp.EventManagementDBDataSet();
            this.cmbGathering = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntryClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventManagementDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventManagementDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(208, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Entry Class";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gathering";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seat Allocation";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(191, 119);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(222, 26);
            this.txtClassName.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(191, 174);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(171, 26);
            this.txtPrice.TabIndex = 6;
            // 
            // txtSeats
            // 
            this.txtSeats.Location = new System.Drawing.Point(228, 240);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(169, 26);
            this.txtSeats.TabIndex = 7;
            // 
            // dgvEntryClass
            // 
            this.dgvEntryClass.AutoGenerateColumns = true;
            this.dgvEntryClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntryClass.DataSource = this.eventManagementDBDataSetBindingSource;
            this.dgvEntryClass.Location = new System.Drawing.Point(477, 23);
            this.dgvEntryClass.Name = "dgvEntryClass";
            this.dgvEntryClass.RowHeadersWidth = 62;
            this.dgvEntryClass.RowTemplate.Height = 28;
            this.dgvEntryClass.Size = new System.Drawing.Size(529, 299);
            this.dgvEntryClass.TabIndex = 8;
            // 
            // eventManagementDBDataSetBindingSource
            // 
            this.eventManagementDBDataSetBindingSource.DataSource = this.eventManagementDBDataSet;
            this.eventManagementDBDataSetBindingSource.Position = 0;
            // 
            // eventManagementDBDataSet
            // 
            this.eventManagementDBDataSet.DataSetName = "EventManagementDBDataSet";
            this.eventManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbGathering
            // 
            this.cmbGathering.FormattingEnabled = true;
            this.cmbGathering.Location = new System.Drawing.Point(191, 57);
            this.cmbGathering.Name = "cmbGathering";
            this.cmbGathering.Size = new System.Drawing.Size(222, 28);
            this.cmbGathering.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(282, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 34);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(435, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EntryClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbGathering);
            this.Controls.Add(this.dgvEntryClass);
            this.Controls.Add(this.txtSeats);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "EntryClassForm";
            this.Text = "EntryClassForm";
            this.Load += new System.EventHandler(this.EntryClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntryClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventManagementDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventManagementDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.DataGridView dgvEntryClass;
        private System.Windows.Forms.BindingSource eventManagementDBDataSetBindingSource;
        private EventManagementDBDataSet eventManagementDBDataSet;
        private System.Windows.Forms.ComboBox cmbGathering;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}