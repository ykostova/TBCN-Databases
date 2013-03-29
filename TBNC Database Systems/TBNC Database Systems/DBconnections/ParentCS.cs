using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TBNC_Database_Systems.DBconnections;

namespace TBNC_Database_Systems.Main
{
    public class ParentCS
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

        private Address mAddress;

        public Address getAddress()
        {
            return mAddress;
        }

        public void setAddress(string _id, string _number, string _name, string _line, string _city, string _county, string _post, string _country)
        {
            mAddress.Id = Convert.ToInt32(_id);
            mAddress.Number = _number;
            mAddress.Name = _name;
            mAddress.Line2 = _line;
            mAddress.Postcode = _post;
            mAddress.Town = _city;
            mAddress.County = _county;
            mAddress.Country = _country;
        }

        private double funding;

        public double Funding
        {
            get { return funding; }
            set { funding = value; }
        }
        private int lateness;

        public int Lateness
        {
            get { return lateness; }
            set { lateness = value; }
        }
        private double outstanding;

        public double Outstanding
        {
            get { return outstanding; }
            set { outstanding = value; }
        }

        public ParentCS(List<string> list, String formatting)
        {
            //work = "";
            //lateness = 0;
            //outstanding = 0;
            switch (formatting)
            {
                case "withAddress": withAddress(list);
                    break;

                case "allParent": allParent(list);
                    break;
            
            }

        }

        private void withAddress(List<string> list)
        { 
        
        }

        private void allParent(List<string> list)
        {

        }


    }
}
