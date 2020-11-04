using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITS.Exception
{
    class AttendanceException:ApplicationException
    {
        public AttendanceException() : base()
        {

        }
        public AttendanceException(string message) : base(message)
        {

        }

    }
}
