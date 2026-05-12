using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPatron_Click(object sender, EventArgs e)
        {
            PatronForm form = new PatronForm();
            form.Show();
        }

        private void btnEntryClass_Click(object sender, EventArgs e)
        {
            EntryClassForm form = new EntryClassForm();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGathering_Click(object sender, EventArgs e)
        {
            GatheringForm form = new GatheringForm();
            form.Show();
        }

        private void btnEntryPass_Click(object sender, EventArgs e)
        {
            EntryPass form = new EntryPass();
            form.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            StaffForm form = new StaffForm();
            form.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm form = new ReportsForm();
            form.Show();
        }

        private void btnVenue_Click(object sender, EventArgs e)
        {
            VenueForm form = new VenueForm();
            form.Show();
        }
    }
}
