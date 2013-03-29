using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TBNC_Database_Systems.Main.Records.Parent;
using TBNC_Database_Systems.DBconnections;
using MySql.Data.MySqlClient;

namespace TBNC_Database_Systems.Main.Records.Child
{
    public partial class RegisterChild : Form
    {
        List<ParentCS> list = new List<ParentCS>();
        DBConnect conn = new DBConnect();
        

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
            int returnV = conn.InsertReturnAddress(add_number.Text, add_name.Text, add_line.Text, add_city.Text, add_county.Text, add_postcode.Text, add_country.Text);
            
            //MessageBox.Show(returnV.ToString(), "Address Result");
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
