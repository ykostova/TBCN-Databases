using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.Main
{
    class ChildRecord
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime start;

        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }
        private DateTime left;

        public DateTime Left
        {
            get { return left; }
            set { left = value; }
        }
        private double regular;

        public double Regular
        {
            get { return regular; }
            set { regular = value; }
        }
        private int department;

        public int Department
        {
            get { return department; }
            set { department = value; }
        }
        private double deposit;

        public double Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }
        private bool paid_back;

        public bool Paid_back
        {
            get { return paid_back; }
            set { paid_back = value; }
        }

        public ChildRecord()
        { 
            deposit = 0;
            //left = null;
        }
    }
}
