using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class ParentToChild
    {
        private int id;

        public int Id
        {
          get { return id; }
          set { id = value; }
        }
        private string relationship;

        public string Relationship
        {
          get { return relationship; }
          set { relationship = value; }
        }
        private bool custody;

        public bool Custody
        {
            get { return custody; }
            set { custody = value; }
        }
        private int child;

        public int Child
        {
            get { return child; }
            set { child = value; }
        }
        private int parent;

        public int Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        public ParentToChild()
        {
        
        }
    }
}
