using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class MedicalRecord
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string gp_name;

        public string Gp_name
        {
            get { return gp_name; }
            set { gp_name = value; }
        }
        private string gp_surname;

        public string Gp_surname
        {
            get { return gp_surname; }
            set { gp_surname = value; }
        }
        private int address;

        public int Address
        {
            get { return address; }
            set { address = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string conditions;

        public string Conditions
        {
            get { return conditions; }
            set { conditions = value; }
        }
        private string medicaments;

        public string Medicaments
        {
            get { return medicaments; }
            set { medicaments = value; }
        }
        private string dosage;

        public string Dosage
        {
            get { return dosage; }
            set { dosage = value; }
        }
        private string allergies;

        public string Allergies
        {
            get { return allergies; }
            set { allergies = value; }
        }
        private string preferences;

        public string Preferences
        {
            get { return preferences; }
            set { preferences = value; }
        }
        private int employee_record;

        public int Employee_record
        {
            get { return employee_record; }
            set { employee_record = value; }
        }
        private int child_record;

        public int Child_record
        {
            get { return child_record; }
            set { child_record = value; }
        }

        public MedicalRecord()
        {
            conditions = "";
            medicaments = "";
            dosage = "";
            allergies = "";
            preferences = "";
            if(employee_record != 0)child_record = 0;
            else employee_record = 0;
        }
    }
}
