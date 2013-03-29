using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TBNC_Database_Systems.Main.Records.Parent;

namespace TBNC_Database_Systems.Main.Records.Child
{
    public partial class RegisterChild : Form
    {
        public RegisterChild()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
        }

        private void btnRegParent_Click(object sender, EventArgs e)
        {
            RegisterParent regp = new RegisterParent();
            regp.Owner = this;

            regp.Show();
            this.Hide();
        }
    }
}
