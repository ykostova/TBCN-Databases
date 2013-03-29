using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class Qualification
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
        private string level;

        public string Level
        {
            get { return level; }
            set { level = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private int employee_record;

        public int Employee_record
        {
            get { return employee_record; }
            set { employee_record = value; }
        }

        public Qualification()
        {
            description = "";
        }
    }
}
