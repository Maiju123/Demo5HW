using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication
{
    class Zoo
    {
        public string Name { get; set; }

        private List<Animal> animals;
        private List<Customer> customers;
        private List<Staff> staffs;

        public Zoo()
        {
            animals = new List<Animal>();
            customers = new List<Customer>();
            staffs = new List<Staff>();
        }
        /// ANIMAL ADDS, GETS AND FINDS

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public Animal GetAnimal(int index)
        {

            if (index < animals.Count)
            {
                return animals.ElementAt(index);
            }
            else
            {
                return null;
            }
        }

        public Animal FindAnimal(int AnimalID)
        {
            foreach (Animal animal in animals)
            {
                if (AnimalID.Equals(animal.AnimalID))
                {
                    return animal; 
                }
            }
            return null;
        }

        public void PrintDataAnimal()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("********* ZOOO **********");
            Console.WriteLine("******** ANIMALS ********");
            Console.WriteLine("*************************");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animals.ToString());
            }
        }
        
        // ADD AND GETS CUSTOMERS TO ZOO 

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public Customer GetCustomer(int index)
        {

            if (index < customers.Count)
            {
                return customers.ElementAt(index);
            }
            else
            {
                return null;
            }
        }

        public void PrintDataCustomer()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("********* ZOOO **********");
            Console.WriteLine("******* CUSTOMERS *******");
            Console.WriteLine("*************************");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customers.ToString());
            }
        }

        // ADD AND GETS STAFF TO ZOO 

        public void AddStaff(Staff staff)
        {
            staffs.Add(staff);
        }

        public Staff GetStaff(int index)
        {

            if (index < staffs.Count)
            {
                return staffs.ElementAt(index);
            }
            else
            {
                return null;
            }
        }

        public void PrintDataStaff()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("********* ZOOO **********");
            Console.WriteLine("********* STAFF *********");
            Console.WriteLine("*************************");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(staffs.ToString());
            }
        }
    }
}
