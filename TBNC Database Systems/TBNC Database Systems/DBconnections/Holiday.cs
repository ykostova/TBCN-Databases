using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TBNC_Database_Systems.DBconnections
{
    class Holiday
    {
        private int id;

        public int Id
        {
          get { return id; }
          set { id = value; }
        }
        
        private DateTime start;

        public DateTime Start
        {
          get { return start; }
          set { start = value; }
        }

        private DateTime end;

        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }
        private double duration;

        public double Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        private int employee_record;

        public int Employee_record
        {
            get { return employee_record; }
            set { employee_record = value; }
        }

        private string notes;

        public string Notes
        {
          get { return notes; }
          set { notes = value; }
        }

        private DateTime requested;

        public DateTime Requested
        {
            get { return requested; }
            set { requested = value; }
        }
        private DateTime approval;

        public DateTime Approval
        {
            get { return approval; }
            set { approval = value; }
        }
        private bool confirmed;

        public bool Confirmed
        {
            get { return confirmed; }
            set { confirmed = value; }
        }
        private double remaining;

        public double Remaining
        {
            get { return remaining; }
            set { remaining = value; }
        }

        public Holiday()
        {
            notes = "";
            //approval= null;
        }
    }
}
