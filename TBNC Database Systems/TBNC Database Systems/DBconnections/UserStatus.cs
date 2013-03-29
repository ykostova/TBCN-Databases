using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class UserStatus
    {
        private int id;

        public int Id
        {
          get { return id; }
          set { id = value; }
        }
        private string value;

        public string Value
        {
          get { return this.value; }
          set { this.value = value; }
        }
        private string permission;

        public string Permission
        {
          get { return permission; }
          set { permission = value; }
        }
        
        public UserStatus()
        {
        
        }
    }
}
