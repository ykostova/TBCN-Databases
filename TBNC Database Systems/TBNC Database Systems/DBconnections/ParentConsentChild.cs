using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class ParentConsentChild
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private bool permission;

        public bool Permission
        {
            get { return permission; }
            set { permission = value; }
        }
        private int activity_consent;

        public int Activity_consent
        {
            get { return activity_consent; }
            set { activity_consent = value; }
        }
        private int parent_to_child;

        public int Parent_to_child
        {
            get { return parent_to_child; }
            set { parent_to_child = value; }
        }

        public ParentConsentChild()
        { 
        }
    }
}
