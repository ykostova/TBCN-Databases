using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class Department
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
        private double daily_charge;

        public double Daily_charge
        {
            get { return daily_charge; }
            set { daily_charge = value; }
        }
        private double weekly_charge;

        public double Weekly_charge
        {
            get { return weekly_charge; }
            set { weekly_charge = value; }
        }
        private double tea_charge;

        public double Tea_charge
        {
            get { return tea_charge; }
            set { tea_charge = value; }
        }
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        private double youngest;

        public double Youngest
        {
            get { return youngest; }
            set { youngest = value; }
        }
        private double oldest;

        public double Oldest
        {
            get { return oldest; }
            set { oldest = value; }
        }
        private int children;

        public int Children
        {
            get { return children; }
            set { children = value; }
        }
        private int staff;

        public int Staff
        {
            get { return staff; }
            set { staff = value; }
        }
        private int staff_required;

        public int Staff_required
        {
            get { return staff_required; }
            set { staff_required = value; }
        }
        private int ratio;

        public int Ratio
        {
            get { return ratio; }
            set { ratio = value; }
        }

        public Department()
        {
            staff = 0;
            children = 0;
        }

    }
}
