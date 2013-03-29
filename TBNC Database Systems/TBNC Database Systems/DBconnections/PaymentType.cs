using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class PaymentType
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
        private string details;

        public string Details
        {
          get { return details; }
          set { details = value; }
        }

        public PaymentType()
        {
        }
    }
}
