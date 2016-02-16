using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication
{
    class Staff : Person
    {
        public int StaffID { get; set; }
        public string Position { get; set; }

        public Staff()
        {

        }
        public Staff(string name, string sex, int staffID, string position)
            : base(name, sex)
            {
            StaffID = staffID;
            Position = position;
            }
        public override string ToString()
        {
            // pulls attributes from Person Class
            return base.ToString() + StaffID + Position;
        }
    }
}
