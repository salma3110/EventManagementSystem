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
            LoadStaffCombo();
            LoadGatheringsCombo();
            LoadAssignments();
        }

        // ── Load staff into grid ──
        private void LoadStaff()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT staff_id AS ID, fname AS FirstName, lname AS LastName FROM Staff ORDER BY fname", con);
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

        // ── Load staff into dropdown ──
        private void LoadStaffCombo()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT staff_id, fname + ' ' + lname AS full_name FROM Staff ORDER BY fname", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbStaff.DataSource = dt;
                    cmbStaff.DisplayMember = "full_name";
                    cmbStaff.ValueMember = "staff_id";
                    cmbStaff.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff dropdown: " + ex.Message);
            }
        }

        // ── Load gatherings into dropdown ──
        private void LoadGatheringsCombo()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT gathering_id, title FROM Gathering ORDER BY date DESC", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbGathering.DataSource = dt;
                    cmbGathering.DisplayMember = "title";
                    cmbGathering.ValueMember = "gathering_id";
                    cmbGathering.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading gatherings: " + ex.Message);
            }
        }

        // ── Load all assignments into grid ──
        private void LoadAssignments()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = @"SELECT 
                                        g.title                    AS Gathering,
                                        s.fname + ' ' + s.lname   AS StaffMember,
                                        gs.role                    AS Role
                                     FROM GatheringStaff gs
                                     JOIN Gathering g ON gs.gathering_id = g.gathering_id
                                     JOIN Staff     s ON gs.staff_id     = s.staff_id
                                     ORDER BY g.title, gs.role";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAssignments.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assignments: " + ex.Message);
            }
        }

        // ── Save new staff ──
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
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Staff (fname, lname) VALUES (@fname, @lname)", con);
                    cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                    cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff saved successfully! ✅");
                    LoadStaff();
                    LoadStaffCombo();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ── Assign staff to gathering ──
        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cmbStaff.SelectedValue == null)
            {
                MessageBox.Show("Please select a staff member.");
                return;
            }
            if (cmbGathering.SelectedValue == null)
            {
                MessageBox.Show("Please select a gathering.");
                return;
            }
            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();
                    string query = @"INSERT INTO GatheringStaff (gathering_id, staff_id, role)
                                     VALUES (@gid, @sid, @role)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@gid", cmbGathering.SelectedValue);
                    cmd.Parameters.AddWithValue("@sid", cmbStaff.SelectedValue);
                    cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff assigned successfully! ✅");
                    LoadAssignments();
                    cmbStaff.SelectedIndex = -1;
                    cmbGathering.SelectedIndex = -1;
                    cmbRole.SelectedIndex = -1;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("This staff member is already assigned to this gathering!");
                else
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