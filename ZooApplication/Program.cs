/*
 * Copyright (C) MHS
 *
 * This file is part of the Person Register project.
 *
 * Created: 16.2.2015
 * Authors: Maiju Schreck
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApplication
{
    class Program
    {
        static void Main(string[] args)
        {


            // create ZOO
            Zoo zoo = new Zoo();

            //Print zoo
            zoo.PrintDataAnimal();

            //Create few animals
            Animal animal = new Animal("Severus ", "Male ", 1, " Snake");
            ///Console.WriteLine("Name: " +animal.Name);
            ///Console.WriteLine("Person: " + animal.Sex);
            ///Console.WriteLine("AnimalID: " + animal.AnimalID);
            ///Console.WriteLine("Spiece: " + animal.Spiece);
            ///animal.shss();

            Animal animal2 = new Animal("Mufasa", "Male ", 2, "Lion");
            ///Console.WriteLine("Name: " + animal2.Name);
            ///Console.WriteLine("Person: " + animal2.Sex);
            ///Console.WriteLine("AnimalID: " + animal2.AnimalID);
            ///Console.WriteLine("Spiece: " + animal2.Spiece);
            ///animal.raws();

            // add animals to ZOO
            zoo.AddAnimal(animal);
            zoo.AddAnimal(animal2);

            //get animal from zoo
            Animal animal3 = zoo.GetAnimal(0);
            if (animal3 != null)
            {
                Console.WriteLine(animal3.ToString());
            }
            else
            {
                Console.WriteLine("There is no animals on this index...");
            }
            Animal animal4 = zoo.GetAnimal(0);
            if (animal4 != null)
            {
                Console.WriteLine(animal4.ToString());
            }
            else
            {
                Console.WriteLine("There is no animals on this index...");
            }

            // PRINT Staff board
            zoo.PrintDataStaff();

            // Create Staff
            Staff staff = new Staff("Liisa Happy ", "Female ", 88, " Cleaner");
            Staff staff1 = new Staff("Yo Ling ", "Female ", 5, " Ticket Seller");
            Staff staff2 = new Staff("Chris Williams ", "Male ", 7, " Manager");

            // add Staff to ZOO
            zoo.AddStaff(staff);

            // get STAFF from ZOO 
            Staff staff3 = zoo.GetStaff(0);
            Console.WriteLine(staff3.ToString());

            Staff staff4 = zoo.GetStaff(1);
            Console.WriteLine(staff2.ToString());

            Staff staff5 = zoo.GetStaff(2);
            Console.WriteLine(staff3.ToString());

            //PRINT Customer board
            zoo.PrintDataCustomer();

            //Create Customers 
            Customer customer = new Customer("Pekka", "Male ", true);

            // add Customers to ZOO
            zoo.AddCustomer(customer);

            //get Customer from Zoo
            Customer customer1 = zoo.GetCustomer(0);
            Console.WriteLine(customer1.ToString());



        }
    }
}
