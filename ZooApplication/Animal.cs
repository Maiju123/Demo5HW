using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication
{
    class Animal : Person, Cats, Male_Lion, Snakes 
    {
        public int AnimalID { get; set; }
        private string spiece;

        public string Spiece
        {
            get
            {
                return spiece;
            }
          set
            {
                if (Spiece == "Lion")
                {
                    raws();
                }
            } 
        }

        public Animal()
        {

        }
        public Animal(string name, string sex, int animalID, string spiece)
            : base(name, sex)
        {
            Spiece = spiece;
            AnimalID = animalID;
        }

        public override string ToString()
        {
            // pulls attributes from Person Class
            return base.ToString() + AnimalID + Spiece;
        }

        public void mews()
        {
            Console.WriteLine("CAT SAYS *miuww*");
        }
        public void raws()
        {
            Console.WriteLine("LION SAYS*RAWWWW!*");
        }
        public void shss()
        {
            Console.WriteLine("SNAKE SAYS *SHZHZHZZ*");
        }
    }

}
