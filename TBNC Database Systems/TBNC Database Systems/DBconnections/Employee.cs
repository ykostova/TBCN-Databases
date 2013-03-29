using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class Employee
    {
        private int id;
        private string merital;
        private string name;
        private string surname;
        private string mobile;
        private string home;
        private char gender;
        private bool driver;
        private DateTime dob;
        private int address;
        private string email;
        private Boolean endorsement;
        private Boolean conviction;
        private string disability;

        public Employee()
        {
            mobile = "";
            email = "";
            disability = "";
        }
    }
}
