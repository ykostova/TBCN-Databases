namespace TBNC_Database_Systems.Main.Records
{
    partial class Records
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Children = new System.Windows.Forms.TabPage();
            this.btnManageChild = new System.Windows.Forms.Button();
            this.btnRegisterChild = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Parents = new System.Windows.Forms.TabPage();
            this.btnManageParents = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddParent = new System.Windows.Forms.Button();
            this.Dept = new System.Windows.Forms.TabPage();
            this.btnManageDept = new System.Windows.Forms.Button();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Employees = new System.Windows.Forms.TabPage();
            this.btnManageEmployees = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Suppliers = new System.Windows.Forms.TabPage();
            this.btnManageSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnDept = new System.Windows.Forms.Button();
            this.btnParents = new System.Windows.Forms.Button();
            this.btnChildren = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.Children.SuspendLayout();
            this.Parents.SuspendLayout();
            this.Dept.SuspendLayout();
            this.Employees.SuspendLayout();
            this.Suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Records";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(27, 112);
            this.btnBack.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 30);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Controls.Add(this.btnSuppliers);
            this.panel1.Controls.Add(this.btnEmployees);
            this.panel1.Controls.Add(this.btnDept);
            this.panel1.Controls.Add(this.btnParents);
            this.panel1.Controls.Add(this.btnChildren);
            this.panel1.Location = new System.Drawing.Point(27, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 451);
            this.panel1.TabIndex = 15;
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.Children);
            this.tabControl.Controls.Add(this.Parents);
            this.tabControl.Controls.Add(this.Dept);
            this.tabControl.Controls.Add(this.Employees);
            this.tabControl.Controls.Add(this.Suppliers);
            this.tabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl.Location = new System.Drawing.Point(261, 35);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(443, 390);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 21;
            // 
            // Children
            // 
            this.Children.BackColor = System.Drawing.Color.White;
            this.Children.Controls.Add(this.btnManageChild);
            this.Children.Controls.Add(this.btnRegisterChild);
            this.Children.Controls.Add(this.label2);
            this.Children.Location = new System.Drawing.Point(4, 5);
            this.Children.Name = "Children";
            this.Children.Size = new System.Drawing.Size(435, 381);
            this.Children.TabIndex = 0;
            this.Children.Text = "Children";
            // 
            // btnManageChild
            // 
            this.btnManageChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageChild.Location = new System.Drawing.Point(29, 125);
            this.btnManageChild.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnManageChild.Name = "btnManageChild";
            this.btnManageChild.Size = new System.Drawing.Size(114, 47);
            this.btnManageChild.TabIndex = 16;
            this.btnManageChild.Text = "Manage Children";
            this.btnManageChild.UseVisualStyleBackColor = true;
            this.btnManageChild.Click += new System.EventHandler(this.btnManageChild_Click);
            // 
            // btnRegisterChild
            // 
            this.btnRegisterChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterChild.Location = new System.Drawing.Point(29, 80);
            this.btnRegisterChild.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnRegisterChild.Name = "btnRegisterChild";
            this.btnRegisterChild.Size = new System.Drawing.Size(114, 30);
            this.btnRegisterChild.TabIndex = 15;
            this.btnRegisterChild.Text = "Register Child";
            this.btnRegisterChild.UseVisualStyleBackColor = true;
            this.btnRegisterChild.Click += new System.EventHandler(this.btnRegisterChild_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Children";
            // 
            // Parents
            // 
            this.Parents.BackColor = System.Drawing.Color.White;
            this.Parents.Controls.Add(this.btnManageParents);
            this.Parents.Controls.Add(this.label3);
            this.Parents.Controls.Add(this.btnAddParent);
            this.Parents.Location = new System.Drawing.Point(4, 5);
            this.Parents.Name = "Parents";
            this.Parents.Size = new System.Drawing.Size(435, 381);
            this.Parents.TabIndex = 1;
            this.Parents.Text = "Parents";
            // 
            // btnManageParents
            // 
            this.btnManageParents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageParents.Location = new System.Drawing.Point(49, 112);
            this.btnManageParents.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnManageParents.Name = "btnManageParents";
            this.btnManageParents.Size = new System.Drawing.Size(114, 46);
            this.btnManageParents.TabIndex = 17;
            this.btnManageParents.Text = "Manage Parents";
            this.btnManageParents.UseVisualStyleBackColor = true;
            this.btnManageParents.Click += new System.EventHandler(this.btnManageParents_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Parents";
            // 
            // btnAddParent
            // 
            this.btnAddParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddParent.Location = new System.Drawing.Point(49, 68);
            this.btnAddParent.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnAddParent.Name = "btnAddParent";
            this.btnAddParent.Size = new System.Drawing.Size(114, 30);
            this.btnAddParent.TabIndex = 15;
            this.btnAddParent.Text = "Add Parent";
            this.btnAddParent.UseVisualStyleBackColor = true;
            this.btnAddParent.Click += new System.EventHandler(this.btnAddParent_Click);
            // 
            // Dept
            // 
            this.Dept.BackColor = System.Drawing.Color.White;
            this.Dept.Controls.Add(this.btnManageDept);
            this.Dept.Controls.Add(this.btnAddDept);
            this.Dept.Controls.Add(this.label5);
            this.Dept.Location = new System.Drawing.Point(4, 5);
            this.Dept.Name = "Dept";
            this.Dept.Size = new System.Drawing.Size(435, 381);
            this.Dept.TabIndex = 2;
            this.Dept.Text = "Dept";
            // 
            // btnManageDept
            // 
            this.btnManageDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDept.Location = new System.Drawing.Point(48, 125);
            this.btnManageDept.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnManageDept.Name = "btnManageDept";
            this.btnManageDept.Size = new System.Drawing.Size(114, 47);
            this.btnManageDept.TabIndex = 23;
            this.btnManageDept.Text = "Manage Dept";
            this.btnManageDept.UseVisualStyleBackColor = true;
            this.btnManageDept.Click += new System.EventHandler(this.btnManageDept_Click);
            // 
            // btnAddDept
            // 
            this.btnAddDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDept.Location = new System.Drawing.Point(48, 80);
            this.btnAddDept.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(114, 30);
            this.btnAddDept.TabIndex = 22;
            this.btnAddDept.Text = "Add Dept";
            this.btnAddDept.UseVisualStyleBackColor = true;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Departments";
            // 
            // Employees
            // 
            this.Employees.BackColor = System.Drawing.Color.White;
            this.Employees.Controls.Add(this.btnManageEmployees);
            this.Employees.Controls.Add(this.btnAddEmployee);
            this.Employees.Controls.Add(this.label4);
            this.Employees.Location = new System.Drawing.Point(4, 5);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(435, 381);
            this.Employees.TabIndex = 3;
            this.Employees.Text = "Employees";
            // 
            // btnManageEmployees
            // 
            this.btnManageEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployees.Location = new System.Drawing.Point(29, 125);
            this.btnManageEmployees.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnManageEmployees.Name = "btnManageEmployees";
            this.btnManageEmployees.Size = new System.Drawing.Size(114, 47);
            this.btnManageEmployees.TabIndex = 19;
            this.btnManageEmployees.Text = "Manage Employees";
            this.btnManageEmployees.UseVisualStyleBackColor = true;
            this.btnManageEmployees.Click += new System.EventHandler(this.btnManageEmployees_Click_1);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(29, 80);
            this.btnAddEmployee.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(114, 30);
            this.btnAddEmployee.TabIndex = 18;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Employees";
            // 
            // Suppliers
            // 
            this.Suppliers.BackColor = System.Drawing.Color.White;
            this.Suppliers.Controls.Add(this.btnManageSupplier);
            this.Suppliers.Controls.Add(this.btnAddSupplier);
            this.Suppliers.Controls.Add(this.label6);
            this.Suppliers.Location = new System.Drawing.Point(4, 5);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Size = new System.Drawing.Size(435, 381);
            this.Suppliers.TabIndex = 4;
            this.Suppliers.Text = "Supplier";
            // 
            // btnManageSupplier
            // 
            this.btnManageSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSupplier.Location = new System.Drawing.Point(29, 159);
            this.btnManageSupplier.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnManageSupplier.Name = "btnManageSupplier";
            this.btnManageSupplier.Size = new System.Drawing.Size(114, 47);
            this.btnManageSupplier.TabIndex = 19;
            this.btnManageSupplier.Text = "Manage Supplier";
            this.btnManageSupplier.UseVisualStyleBackColor = true;
            this.btnManageSupplier.Click += new System.EventHandler(this.btnManageSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.Location = new System.Drawing.Point(29, 80);
            this.btnAddSupplier.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(114, 62);
            this.btnAddSupplier.TabIndex = 18;
            this.btnAddSupplier.Text = "Register Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Suppliers";
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(31, 339);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(177, 51);
            this.btnSuppliers.TabIndex = 20;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(31, 269);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(177, 51);
            this.btnEmployees.TabIndex = 19;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnDept
            // 
            this.btnDept.Location = new System.Drawing.Point(31, 199);
            this.btnDept.Name = "btnDept";
            this.btnDept.Size = new System.Drawing.Size(177, 51);
            this.btnDept.TabIndex = 18;
            this.btnDept.Text = "Departments";
            this.btnDept.UseVisualStyleBackColor = true;
            this.btnDept.Click += new System.EventHandler(this.btnDept_Click);
            // 
            // btnParents
            // 
            this.btnParents.Location = new System.Drawing.Point(31, 131);
            this.btnParents.Name = "btnParents";
            this.btnParents.Size = new System.Drawing.Size(177, 51);
            this.btnParents.TabIndex = 17;
            this.btnParents.Text = "Parents";
            this.btnParents.UseVisualStyleBackColor = true;
            this.btnParents.Click += new System.EventHandler(this.btnParents_Click);
            // 
            // btnChildren
            // 
            this.btnChildren.Location = new System.Drawing.Point(31, 60);
            this.btnChildren.Name = "btnChildren";
            this.btnChildren.Size = new System.Drawing.Size(177, 51);
            this.btnChildren.TabIndex = 16;
            this.btnChildren.Text = "Children";
            this.btnChildren.UseVisualStyleBackColor = true;
            this.btnChildren.Click += new System.EventHandler(this.btnChildren_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TBNC_Database_Systems.Properties.Resources.tbnc_top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 86);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(221)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "Records";
            this.Text = "Records";
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.Children.ResumeLayout(false);
            this.Children.PerformLayout();
            this.Parents.ResumeLayout(false);
            this.Parents.PerformLayout();
            this.Dept.ResumeLayout(false);
            this.Dept.PerformLayout();
            this.Employees.ResumeLayout(false);
            this.Employees.PerformLayout();
            this.Suppliers.ResumeLayout(false);
            this.Suppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnDept;
        private System.Windows.Forms.Button btnParents;
        private System.Windows.Forms.Button btnChildren;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Children;
        private System.Windows.Forms.TabPage Parents;
        private System.Windows.Forms.TabPage Dept;
        private System.Windows.Forms.TabPage Employees;
        private System.Windows.Forms.TabPage Suppliers;
        private System.Windows.Forms.Button btnManageChild;
        private System.Windows.Forms.Button btnRegisterChild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManageParents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddParent;
        private System.Windows.Forms.Button btnManageDept;
        private System.Windows.Forms.Button btnAddDept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnManageEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnManageSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}