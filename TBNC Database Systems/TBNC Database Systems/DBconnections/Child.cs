using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.Main
{
    class Child
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
        private DateTime dob;

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public Child()
        {
        }
    }
}
