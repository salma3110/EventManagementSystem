using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (txtFname.Text == "" || txtLname.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please fill First Name, Last Name and Email.");
                return;
            }

            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO Patron (fname, lname, email, phone_number)
                                     VALUES (@fname, @lname, @email, @phone)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                    cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patron registered successfully! ✅");

                    // Clear fields
                    txtFname.Text = "";
                    txtLname.Text = "";
                    txtEmail.Text = "";
                    txtPhone.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
