using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class Training
    {
        private int id;

        public int Id
        {
          get { return id; }
          set { id = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
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
        private double duration;

        public double Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        private int employee_record;

        public int Employee_record
        {
            get { return employee_record; }
            set { employee_record = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        public Training()
        {
            description = "";
        }
    }
}
