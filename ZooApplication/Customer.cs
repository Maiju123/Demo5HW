using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication
{
    class Customer : Person
    {
        public bool Family { get; set; }
        public Customer()
        {

        }
        public Customer(string name, string sex, bool family)
                : base(name, sex)
        {
            Family = family;
        }
        public override string ToString()
        {
            // pulls attributes from Person Class
            return base.ToString() + "Family: " + Family;
        }
    }
}

