using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EventManagementApp
{
    public partial class GatheringForm : Form
    {
        public GatheringForm()
        {
            InitializeComponent();
        }

        private void GatheringForm_Load(object sender, EventArgs e)
        {
            LoadVenues();
            LoadGatherings();
        }

        private void LoadVenues()
        {
            SqlConnection con = DBConnection.GetConnection();
            DataTable dt = new DataTable();
            new SqlDataAdapter("SELECT venue_id, name FROM Venue", con).Fill(dt);
            cmbVenue.DisplayMember = "name";
            cmbVenue.ValueMember = "venue_id";
            cmbVenue.DataSource = dt;
        }

        private void LoadGatherings()
        {
            SqlConnection con = DBConnection.GetConnection();
            string query = @"SELECT g.gathering_id, g.title, g.date, g.category, v.name AS Venue
                             FROM Gathering g JOIN Venue v ON g.venue_id = v.venue_id";
            DataTable dt = new DataTable();
            new SqlDataAdapter(query, con).Fill(dt);
            dgvGatherings.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = DBConnection.GetConnection();
            string query = "INSERT INTO Gathering (title, date, category, venue_id) VALUES (@t, @d, @c, @v)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@t", txtTitle.Text);
            cmd.Parameters.AddWithValue("@d", dtpDate.Value.Date);
            cmd.Parameters.AddWithValue("@c", txtCategory.Text);
            cmd.Parameters.AddWithValue("@v", cmbVenue.SelectedValue);
            con.Open(); cmd.ExecuteNonQuery(); con.Close();
            MessageBox.Show("Gathering saved!");
            LoadGatherings();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGatherings.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvGatherings.SelectedRows[0].Cells["gathering_id"].Value);
            SqlConnection con = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Gathering WHERE gathering_id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open(); cmd.ExecuteNonQuery(); con.Close();
            LoadGatherings();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvGatherings.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvGatherings.SelectedRows[0].Cells["gathering_id"].Value);
            SqlConnection con = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Gathering SET category = @c WHERE gathering_id = @id", con);
            cmd.Parameters.AddWithValue("@c", txtCategory.Text);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open(); cmd.ExecuteNonQuery(); con.Close();
            LoadGatherings();
        }
    }
}
