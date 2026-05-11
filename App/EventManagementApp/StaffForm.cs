using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EventManagementApp
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            LoadStaff();
        }

        private void LoadStaff()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = @"SELECT 
                                        staff_id AS ID,
                                        fname    AS FirstName,
                                        lname    AS LastName
                                     FROM Staff
                                     ORDER BY fname";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvStaff.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff: " + ex.Message);
            }
        }

        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == "" || txtLname.Text == "")
            {
                MessageBox.Show("Please enter both First Name and Last Name.");
                return;
            }

            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = @"INSERT INTO Staff (fname, lname)
                                     VALUES (@fname, @lname)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                    cmd.Parameters.AddWithValue("@lname", txtLname.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff saved successfully! ✅");
                    LoadStaff();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClearStaff_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtFname.Text = "";
            txtLname.Text = "";
        }
    }
}