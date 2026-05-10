using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EventManagementApp
{
    public partial class PatronForm : Form
    {
        public PatronForm()
        {
            InitializeComponent();
        }

        private void PatronForm_Load(object sender, EventArgs e)
        {
            LoadPatrons();
        }

        private void LoadPatrons()
        {
            SqlConnection con = DBConnection.GetConnection();
            string query = "SELECT patron_id, fname, lname, email, phone_number FROM Patron";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPatrons.DataSource = dt;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = DBConnection.GetConnection();
            string query = "INSERT INTO Patron (fname, lname, email, phone_number, password_hash) VALUES (@fn, @ln, @em, @ph, 'defaultpass')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@fn", txtFname.Text);
            cmd.Parameters.AddWithValue("@ln", txtLname.Text);
            cmd.Parameters.AddWithValue("@em", txtEmail.Text);
            cmd.Parameters.AddWithValue("@ph", txtPhone.Text);
            con.Open(); cmd.ExecuteNonQuery(); con.Close();
            MessageBox.Show("Patron registered!");
            LoadPatrons();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatrons.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvPatrons.SelectedRows[0].Cells["patron_id"].Value);
            SqlConnection con = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Patron WHERE patron_id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open(); cmd.ExecuteNonQuery(); con.Close();
            LoadPatrons();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPatrons.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvPatrons.SelectedRows[0].Cells["patron_id"].Value);
            SqlConnection con = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Patron SET phone_number = @ph WHERE patron_id = @id", con);
            cmd.Parameters.AddWithValue("@ph", txtPhone.Text);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open(); cmd.ExecuteNonQuery(); con.Close();
            LoadPatrons();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}