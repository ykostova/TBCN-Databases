using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class MedicalEmergency
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
        private string medication;

        public string Medication
        {
            get { return medication; }
            set { medication = value; }
        }
        private string dosage;

        public string Dosage
        {
            get { return dosage; }
            set { dosage = value; }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private int child_record;

        public int Child_record
        {
            get { return child_record; }
            set { child_record = value; }
        }

        public MedicalEmergency()
        {
            description = "";
            //date = null;
        }
    }
}
