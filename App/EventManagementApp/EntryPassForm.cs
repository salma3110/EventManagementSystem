using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EventManagementApp
{
    public partial class EntryPassForm : Form
    {
        public EntryPassForm()
        {
            InitializeComponent();
        }

        private void EntryPassForm_Load(object sender, EventArgs e)
        {
            LoadPatrons();
            LoadGatherings();
            LoadPasses();
            cmbGathering.SelectedIndexChanged += cmbGathering_SelectedIndexChanged;
            cmbClass.SelectedIndexChanged += cmbClass_SelectedIndexChanged;
        }

        private void LoadPatrons()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT patron_id, fname + ' ' + lname AS full_name FROM Patron ORDER BY fname", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbPatron.DataSource = dt;
                    cmbPatron.DisplayMember = "full_name";
                    cmbPatron.ValueMember = "patron_id";
                    cmbPatron.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patrons: " + ex.Message);
            }
        }

        private void LoadGatherings()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT gathering_id, title + ' (' + category + ')' AS info FROM Gathering ORDER BY date DESC", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbGathering.DataSource = dt;
                    cmbGathering.DisplayMember = "info";
                    cmbGathering.ValueMember = "gathering_id";
                    cmbGathering.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading gatherings: " + ex.Message);
            }
        }

        private void cmbGathering_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGathering.SelectedValue == null) return;

            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = @"SELECT 
                                        class_id,
                                        class_name + ' - ' + 
                                        CAST(price AS VARCHAR) + ' EGP' AS info
                                     FROM EntryClass
                                     WHERE gathering_id = @gid";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@gid", cmbGathering.SelectedValue);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbClass.DataSource = dt;
                    cmbClass.DisplayMember = "info";
                    cmbClass.ValueMember = "class_id";
                    cmbClass.SelectedIndex = -1;
                    lblSeats.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading classes: " + ex.Message);
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClass.SelectedValue == null) return;

            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = @"SELECT 
                                        ec.seats_allocation - COUNT(ep.pass_id) AS available
                                     FROM EntryClass ec
                                     LEFT JOIN EntryPass ep ON ec.class_id = ep.class_id
                                     WHERE ec.class_id = @cid
                                     GROUP BY ec.seats_allocation";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@cid", cmbClass.SelectedValue);

                    object result = cmd.ExecuteScalar();
                    int available = result != null ? Convert.ToInt32(result) : 0;
                    lblSeats.Text = "Available seats: " + available;
                    lblSeats.ForeColor = available > 0
                        ? System.Drawing.Color.DarkGreen
                        : System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking seats: " + ex.Message);
            }
        }

        private void LoadPasses()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = @"SELECT 
                                        ep.pass_id                  AS PassID,
                                        p.fname + ' ' + p.lname    AS Patron,
                                        g.title                    AS Gathering,
                                        ec.class_name              AS Class,
                                        ec.price                   AS Price,
                                        ep.purchase_date           AS Date
                                     FROM EntryPass ep
                                     JOIN Patron     p  ON ep.patron_id    = p.patron_id
                                     JOIN EntryClass ec ON ep.class_id     = ec.class_id
                                     JOIN Gathering  g  ON ec.gathering_id = g.gathering_id
                                     ORDER BY ep.purchase_date DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPasses.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading passes: " + ex.Message);
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (cmbPatron.SelectedValue == null)
            {
                MessageBox.Show("Please select a patron.");
                return;
            }
            if (cmbGathering.SelectedValue == null)
            {
                MessageBox.Show("Please select a gathering.");
                return;
            }
            if (cmbClass.SelectedValue == null)
            {
                MessageBox.Show("Please select an entry class.");
                return;
            }

            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = @"INSERT INTO EntryPass (purchase_date, patron_id, class_id)
                                     VALUES (@date, @patron, @class)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@date", DateTime.Today);
                    cmd.Parameters.AddWithValue("@patron", cmbPatron.SelectedValue);
                    cmd.Parameters.AddWithValue("@class", cmbClass.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Entry pass purchased successfully! ✅");
                    LoadPasses();
                    ClearFields();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("This patron already has a pass for this class!");
                else
                    MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            cmbPatron.SelectedIndex = -1;
            cmbGathering.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            lblSeats.Text = "";
        }
    }
}