using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.Main
{
    class Parent
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

        public Parent()
        {
            work = "";
            lateness = 0;
            outstanding = 0;
        }
    }
}
