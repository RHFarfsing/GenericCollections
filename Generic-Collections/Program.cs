using System;
using System.Collections.Generic;

namespace Generic_Collections {
    class Program {
        static void Main(string[] args) {
            var ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            Console.WriteLine($"Number of ints is {ints.Count}");
            foreach (var anInt in ints) {
                Console.Write($" {anInt} ");
            }
            ints.Remove(2);
            Console.WriteLine($"Number of ints is {ints.Count}");
            foreach (var anInt in ints) {
                Console.Write($" {anInt} ");
            }
            var names = new List<string>();
            names.Add("Robbie");
            names.Add("Armon");
            names.Add("Danae");
            names.Add("Traci");
            names.Add("Vaughn");
            names.Add("George");
            names.Add("Ian");
            names.Add("Laura");
            names.Add("Sarah");
            names.Add("Manish");
            names.Add("Parker");
            names.Add("David");
            foreach (var students in names) {
                Console.Write($" {students} ");
            }
            //generic array of strings
            var customers = new List<Customer>();
            var amazon = new Customer(1, "Amazon", true);
            var pg = new Customer(2, "P&G", true);
            var meijer = new Customer { Id = 3, Name = "Meijer", Active = true };
            var target = new Customer { Id = 4, Name = "Target" };
            var microsoft = new Customer { Id = 5, Name = "Microsoft", Active = false };
            customers.Add(amazon);
            customers.Add(pg);
            var custarray = new Customer[] { meijer, target, microsoft };
            customers.AddRange(custarray);
            foreach (var customer in customers) {
                //if(customer.Active==true)
                //    Console.Write($"{customer.Id}, {customer.Name}, {customer.Active}");
                if (customer.Active == false) {
                    continue;
                }
                Console.Write($"{ customer.Id}, {customer.Name}, {customer.Active}");
            }
            var custname = "Not Found";
            foreach (var cust in customers) {
                if (cust.Id == 3) {
                    custname = cust.Name;
                    break;
                }
            }
            Console.Write($" Cust with Id of 3 is {custname}");
            var custDictionary = new Dictionary<int, Customer>();
            custDictionary.Add(amazon.Id, amazon);
            custDictionary.Add(target.Id, target);
            custDictionary.Add(meijer.Id, meijer);
            custDictionary.Add(pg.Id, pg);
            custDictionary.Add(microsoft.Id, microsoft);
            var custname2 = custDictionary[3];
            Console.WriteLine($" Customer id 3 is {custname2.Name}");
            custname2 = custDictionary[2];
            Console.WriteLine($" Customer id 2 is {custDictionary[2].Name}");
            foreach (var key in custDictionary.Keys) {
                var customer = custDictionary[key];
                Console.WriteLine($"{customer.Name}");
            }
        }
    }
}

