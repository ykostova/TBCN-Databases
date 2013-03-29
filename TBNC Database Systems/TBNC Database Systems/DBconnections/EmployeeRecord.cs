using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class EmployeeRecord
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

        private DateTime end;

        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }

        private string PVG;

        public string PVG1
        {
            get { return PVG; }
            set { PVG = value; }
        }

        private DateTime PVG_expiry;

        public DateTime PVG_expiry1
        {
            get { return PVG_expiry; }
            set { PVG_expiry = value; }
        }

        private String SSSC;

        public String SSSC1
        {
            get { return SSSC; }
            set { SSSC = value; }
        }

        private DateTime SSSC_expiry;

        public DateTime SSSC_expiry1
        {
            get { return SSSC_expiry; }
            set { SSSC_expiry = value; }
        }

        private bool long_service;

        public bool Long_service
        {
            get { return long_service; }
            set { long_service = value; }
        }

        private bool full_time;

        public bool Full_time
        {
            get { return full_time; }
            set { full_time = value; }
        }

        private double regular_hours;

        public double Regular_hours
        {
            get { return regular_hours; }
            set { regular_hours = value; }
        }

        private double sickness;

        public double Sickness
        {
            get { return sickness; }
            set { sickness = value; }
        }

        private double holidays;

        public double Holidays
        {
            get { return holidays; }
            set { holidays = value; }
        }

        private int department;

        public int Department
        {
            get { return department; }
            set { department = value; }
        }

        private int user_details;

        public int User_details
        {
            get { return user_details; }
            set { user_details = value; }
        }

        private int employee_id;

        public int Employee_id
        {
            get { return employee_id; }
            set { employee_id = value; }
        }

        private string NIN;

        public string NIN1
        {
            get { return NIN; }
            set { NIN = value; }
        }

        private bool overtime;

        public bool Overtime
        {
            get { return overtime; }
            set { overtime = value; }
        }

        private string external;

        public string External
        {
            get { return external; }
            set { external = value; }
        }

        public EmployeeRecord() 
        {
            end = start;
            long_service = false;
            holidays = 0;
            external = null;
        }
    }
}
