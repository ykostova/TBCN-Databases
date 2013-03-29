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

        public Child(List<string> list)
        {
            id = Convert.ToInt32(list.ElementAt(0));
            name = list.ElementAt(1);
            surname = list.ElementAt(2);
            gender = Convert.ToChar(list.ElementAt(3));
            address = Convert.ToInt32(list.ElementAt(4));
            child_record = Convert.ToInt32(list.ElementAt(5));
            dob = DateTime.Parse(list.ElementAt(6));
        }
    }
}
