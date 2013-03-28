using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TBNC_Database_Systems.Main.Records;
using TBNC_Database_Systems.Main.Holidays;
using TBNC_Database_Systems.Main.Invoices;
using TBNC_Database_Systems.Main.Training___Qualifications;
using TBNC_Database_Systems.Main.User_Accounts;

namespace TBNC_Database_Systems
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {

            Records rec = new Records();
            rec.Owner = this;

            rec.Show();
            this.Hide();
        }

        private void btnHoliday_Click(object sender, EventArgs e)
        {
            Holidays holidays = new Holidays();
            holidays.Owner = this;

            holidays.Show();
            this.Hide();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            Invoices invoices = new Invoices();
            invoices.Owner = this;

            invoices.Show();
            this.Hide();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            Training training = new Training();
            training.Owner = this;

            training.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ManageUsers users = new ManageUsers();
            users.Owner = this;

            users.Show();
            this.Hide();
        }
    }
}
