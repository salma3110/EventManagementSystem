using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EventManagementApp
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadSeatAvailability();
            LoadGatheringSchedule();
        }

        private void RunQuery(DataGridView dgv, string query)
        {
            SqlConnection con = DBConnection.GetConnection();
            DataTable dt = new DataTable();
            new SqlDataAdapter(query, con).Fill(dt);
            dgv.DataSource = dt;
        }

        // Seat availability per class per gathering
        private void LoadSeatAvailability()
        {
            string query = @"
                SELECT 
                    g.title                                 AS Gathering,
                    ec.class_name                           AS Class,
                    ec.price                                AS Price,
                    ec.seats_allocation                     AS Total_Seats,
                    COUNT(ep.pass_id)                       AS Sold,
                    ec.seats_allocation - COUNT(ep.pass_id) AS Available
                FROM Gathering g
                JOIN EntryClass ec ON g.gathering_id = ec.gathering_id
                LEFT JOIN EntryPass ep ON ec.class_id = ep.class_id
                GROUP BY g.title, g.date, ec.class_name, ec.price, ec.seats_allocation
                ORDER BY g.date, g.title";
            RunQuery(dgvSeats, query);
        }

        // Gathering schedule with venue
        private void LoadGatheringSchedule()
        {
            string query = @"
                SELECT 
                    g.title     AS Gathering,
                    g.date      AS Date,
                    g.category  AS Category,
                    v.name      AS Venue,
                    v.city      AS City,
                    v.capacity  AS Venue_Capacity
                FROM Gathering g
                JOIN Venue v ON g.venue_id = v.venue_id
                ORDER BY g.date";
            RunQuery(dgvSchedule, query);
        }
    }
}