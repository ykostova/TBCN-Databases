using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class EmergencyContact
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private char gender;

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private string home;

        public string Home
        {
            get { return home; }
            set { home = value; }
        }
        private string work;

        public string Work
        {
            get { return work; }
            set { work = value; }
        }
        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        private int address;

        public int Address
        {
            get { return address; }
            set { address = value; }
        }
        
        private int child_record;

        public int Child_record
        {
          get { return child_record; }
          set { child_record = value; }
        }
        private int emp_record;

        public int Emp_record
        {
          get { return emp_record; }
          set { emp_record = value; }
        }

        public EmergencyContact()
        {
            mobile = "";
            address = 0;
            if (emp_record != 0) child_record = 0;
            else emp_record = 0;
        }
    }
}
