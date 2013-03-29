using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class Attendance
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        private double extra;

        public double Extra
        {
            get { return extra; }
            set { extra = value; }
        }

        private int teas;

        public int Teas
        {
            get { return teas; }
            set { teas = value; }
        }
        private int month;

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private int childRecord;

        public int ChildRecord
        {
            get { return childRecord; }
            set { childRecord = value; }
        }

        public Attendance()
        {
            total = 0;
            extra = 0;
            teas = 0;
        }
    }
}
