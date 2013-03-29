using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class Invoice
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private int payment;

        public int Payment
        {
            get { return payment; }
            set { payment = value; }
        }
        private bool paid;

        public bool Paid
        {
            get { return paid; }
            set { paid = value; }
        }
        private double outstanding;

        public double Outstanding
        {
            get { return outstanding; }
            set { outstanding = value; }
        }
        private int parent;

        public int Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        private int supplier;

        public int Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }
        private string notes;

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public Invoice()
        { 
            notes="";
            if (parent!=0) supplier = 0;
            else parent = 0;

        }
    }
}
