using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class ActivityConsent
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
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public ActivityConsent()
        {
            description = "";
        }
    }
}
