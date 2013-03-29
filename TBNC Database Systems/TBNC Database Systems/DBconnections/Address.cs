using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    public class Address
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string line2;

        public string Line2
        {
            get { return line2; }
            set { line2 = value; }
        }

        private string town;

        public string Town
        {
            get { return town; }
            set { town = value; }
        }

        private string county;

        public string County
        {
            get { return county; }
            set { county = value; }
        }

        private string postcode;

        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public Address()
        {
            line2 = "";
            county = "";
        }

        public Address(List<string> list)
        {
            id = Convert.ToInt32(list.ElementAt(0));
            number = list.ElementAt(1);
            name = list.ElementAt(2);
            line2 = list.ElementAt(3);
            town = list.ElementAt(4);
            county = list.ElementAt(5);
            postcode = list.ElementAt(6);
            country = list.ElementAt(7);
        }
    }
}
