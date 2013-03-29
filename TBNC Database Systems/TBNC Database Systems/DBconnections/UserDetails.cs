using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class UserDetails
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private DateTime created;

        public DateTime Created
        {
            get { return created; }
            set { created = value; }
        }
        private DateTime edited;

        public DateTime Edited
        {
            get { return edited; }
            set { edited = value; }
        }
        private int user_status;

        public int User_status
        {
            get { return user_status; }
            set { user_status = value; }
        }

        public UserDetails()
        {
            //edited = null;
        }
    }
}
