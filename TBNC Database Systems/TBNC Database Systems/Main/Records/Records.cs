using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TBNC_Database_Systems.Main.Records.Child;
using TBNC_Database_Systems.Main.Records.Parent;
using TBNC_Database_Systems.Main.Records.Departments;
using TBNC_Database_Systems.Main.Records.Employee;
using TBNC_Database_Systems.Main.Records.Supplier;

namespace TBNC_Database_Systems.Main.Records
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnChildren_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void btnParents_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void btnRegisterChild_Click(object sender, EventArgs e)
        {
            RegisterChild registerc = new RegisterChild();
            registerc.Owner = this;

            registerc.Show();
            this.Hide();
        }

        private void btnManageChild_Click(object sender, EventArgs e)
        {
            ManageChild managec = new ManageChild();
            managec.Owner = this;

            managec.Show();
            this.Hide();
        }

        private void btnAddParent_Click(object sender, EventArgs e)
        {
            RegisterParent regParent = new RegisterParent();
            regParent.Owner = this;

            regParent.Show();
            this.Hide();
        }

        private void btnManageParents_Click(object sender, EventArgs e)
        {
            ManageParent managep = new ManageParent();
            managep.Owner = this;

            managep.Show();
            this.Hide();
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            AddDept addDept = new AddDept();
            addDept.Owner = this;

            addDept.Show();
            this.Hide();
        }

        private void btnManageDept_Click(object sender, EventArgs e)
        {
            ManageDept manageDept = new ManageDept();
            manageDept.Owner = this;

            manageDept.Show();
            this.Hide();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            RegisterEmployee regEmployee = new RegisterEmployee();
            regEmployee.Owner = this;

            regEmployee.Show();
            this.Hide();
        }

        private void btnManageEmployees_Click(object sender, EventArgs e)
        {
            ManageEmployees manageEmployees = new ManageEmployees();
            manageEmployees.Owner = this;

            manageEmployees.Show();
            this.Hide();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.Owner = this;

            addSupplier.Show();
            this.Hide();
        }

        private void btnManageSupplier_Click(object sender, EventArgs e)
        {
            ManageSupplier manageSupplier = new ManageSupplier();
            manageSupplier.Owner = this;

            manageSupplier.Show();
            this.Hide();
        }

        private void btnManageEmployees_Click_1(object sender, EventArgs e)
        {
            ManageEmployees manageEmployee = new ManageEmployees();
            manageEmployee.Owner = this;

            manageEmployee.Show();
            this.Hide();
        }
    }
}
