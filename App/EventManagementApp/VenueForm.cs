using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EventManagementApp
{
    public partial class VenueForm : Form
    {
        public VenueForm()
        {
            InitializeComponent();
        }

        private void VenueForm_Load(object sender, EventArgs e)
        {
            LoadVenues();
        }

        private void LoadVenues()
        {
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT 
                                        venue_id    AS ID,
                                        name        AS Name,
                                        street_name AS Street,
                                        city        AS City,
                                        capacity    AS Capacity
                                     FROM Venue 
                                     ORDER BY name";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dvgVenues1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading venues: " + ex.Message);
            }
        }

        private void btnSaveVenue_Click(object sender, EventArgs e)
        {
            if (textVenueName.Text == "")
            {
                MessageBox.Show("Please enter venue name.");
                return;
            }

            int capacity;
            if (!int.TryParse(textCapacity.Text, out capacity) || capacity <= 0)
            {
                MessageBox.Show("Capacity must be a positive number.");
                return;
            }

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO Venue (name, street_name, city, capacity)
                                     VALUES (@name, @street, @city, @capacity)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", textVenueName.Text);
                    cmd.Parameters.AddWithValue("@street", textStreet.Text);
                    cmd.Parameters.AddWithValue("@city", textCity.Text);
                    cmd.Parameters.AddWithValue("@capacity", capacity);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Venue saved successfully! ✅");
                    LoadVenues();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClearVenue_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textVenueName.Text = "";
            textStreet.Text = "";
            textCity.Text = "";
            textCapacity.Text = "";
        }
    }
}