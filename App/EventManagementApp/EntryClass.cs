using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EventManagementApp
{
    public partial class EntryClassForm : Form
    {
        public EntryClassForm()
        {
            InitializeComponent();
        }

        // Form Load

        private void EntryClassForm_Load(object sender, EventArgs e)
        {
            LoadGatherings();
            LoadEntryClasses();
        }

        // Populate the Gathering combo-box
        private void LoadGatherings()
        {
            SqlConnection con = DBConnection.GetConnection();
            DataTable dt = new DataTable();
            new SqlDataAdapter("SELECT gathering_id, title FROM Gathering", con).Fill(dt);
            cmbGathering.DisplayMember = "title";
            cmbGathering.ValueMember = "gathering_id";
            cmbGathering.DataSource = dt;
        }


        // Load all entry classes into the grid

        private void LoadEntryClasses()
        {
            SqlConnection con = DBConnection.GetConnection();


            string query = "SELECT * FROM EntryClass";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvEntryClass.DataSource = null;
            dgvEntryClass.DataSource = dt;

            dgvEntryClass.Refresh();


        }

        //Update – modify selected entry class
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEntryClass.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInputs()) return;

            int id = Convert.ToInt32(
                dgvEntryClass.SelectedRows[0].Cells["class_id"].Value);

            SqlConnection con = DBConnection.GetConnection();
            string query = @"UPDATE EntryClass
                             SET    class_name      = @cn,
                                    price           = @pr,
                                    seats_allocation = @sa,
                                    gathering_id    = @gid
                             WHERE  class_id  = @id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@cn", txtClassName.Text.Trim());
            cmd.Parameters.AddWithValue("@pr", decimal.Parse(txtPrice.Text.Trim()));
            cmd.Parameters.AddWithValue("@sa", int.Parse(txtSeats.Text.Trim()));
            cmd.Parameters.AddWithValue("@gid", cmbGathering.SelectedValue);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Entry class updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
            LoadEntryClasses();
        }

        // Delete – remove selected entry class
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEntryClass.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this entry class?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            int id = Convert.ToInt32(
                dgvEntryClass.SelectedRows[0].Cells["class_id"].Value);

            SqlConnection con = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM EntryClass WHERE class_id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadEntryClasses();
        }
        // When a row is selected in the grid, populate the input fields for editing
        private void dgvEntryClasses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEntryClass.SelectedRows.Count == 0) return;

            DataGridViewRow row = dgvEntryClass.SelectedRows[0];
            txtClassName.Text = row.Cells["class_name"].Value?.ToString();
            txtPrice.Text = row.Cells["price"].Value?.ToString();
            txtSeats.Text = row.Cells["seats_allocation"].Value?.ToString();

            // Sync combo-box to the gathering of the selected row
            string gatheringTitle = row.Cells["Gathering"].Value?.ToString();
            foreach (DataRowView item in cmbGathering.Items)
            {
                if (item["title"].ToString() == gatheringTitle)
                {
                    cmbGathering.SelectedItem = item;
                    break;
                }
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtClassName.Text))
            {
                MessageBox.Show("Please enter a class name.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out _))
            {
                MessageBox.Show("Please enter a valid price (e.g. 49.99).", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtSeats.Text.Trim(), out int seats) || seats <= 0)
            {
                MessageBox.Show("Please enter a valid number of seats (positive integer).",
                                "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbGathering.SelectedValue == null)
            {
                MessageBox.Show("Please select a gathering.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtClassName.Clear();
            txtPrice.Clear();
            txtSeats.Clear();
            if (cmbGathering.Items.Count > 0)
                cmbGathering.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            SqlConnection con = DBConnection.GetConnection();

            string query = @"INSERT INTO EntryClass
                    (class_name, price, seats_allocation, gathering_id)
                    VALUES
                    (@n, @p, @s, @g)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@n", txtClassName.Text);
            cmd.Parameters.AddWithValue("@p", decimal.Parse(txtPrice.Text));
            cmd.Parameters.AddWithValue("@s", int.Parse(txtSeats.Text));
            cmd.Parameters.AddWithValue("@g", cmbGathering.SelectedValue);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Entry Class Added Successfully");

            LoadEntryClasses();
            ClearInputs();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // EntryClassForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "EntryClassForm";
            this.Load += new System.EventHandler(this.EntryClassForm_Load_1);
            this.ResumeLayout(false);

        }

        private void EntryClassForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}