using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITS.Entity
{
    public class Attendance
    {
        #region variables
        int employeeID;
        DateTime date;
        string intime;
        string outtime;
        string notes;
        #endregion



        #region properties
        public int EmployeeID { get => EmployeeID; set => EmployeeID = value; }
        public DateTime Date { get => Date; set => Date = value; }
        
        public string Notes { get => notes; set => notes = value; }
        public string Intime { get => intime; set => intime = value; }
        public string Outtime { get => outtime; set => outtime = value; }

        #endregion

        #region constructors
        public Attendance()
        {

        }


        public Attendance(int empID, DateTime dt, string intm, string outtm, string nts)
        {
            employeeID = empID;
            Date = dt;
            Intime = intm;
            Outtime = outtm;
            notes = nts;

        }
        #endregion
    }
}
