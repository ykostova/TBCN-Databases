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

        private void btnRegParent_Click(object sender, EventArgs e)
        {
            RegisterParent regp = new RegisterParent();
            regp.Owner = this;

            regp.Show();
            this.Hide();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            int returnV = conn.InsertReturnAddress(add_number.Text, add_name.Text, add_line.Text, add_city.Text, add_county.Text, add_postcode.Text, add_country.Text);
            DateTime start = new DateTime(2013, 3, 29);

            conn.InsertChild(returnV, start, Convert.ToDouble(regular_days.Text), 1, 210.00, 0, fName.Text.ToString(), lName.Text.ToString(), Convert.ToChar(gender.Text), dateTimePicker.Value);

            MessageBox.Show((fName.Text.ToString() + " " + lName.Text.ToString() + " added!"), "Child: ");
        }
    }
}
