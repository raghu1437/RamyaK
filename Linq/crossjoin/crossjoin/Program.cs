using System;
using System.Collections.Generic;
using System.Linq;

namespace CrossJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Student1 = new List<Student>()
            {
                new Student(){ID=1, Name = "Ramya", AddressID = 1},
                new Student(){ID=2, Name = "Ram", AddressID = 1},
                new Student(){ID=3, Name = "Rashmi", AddressID = 2},
                new Student(){ID=4, Name = "Laxman", AddressID = 3},
                new Student(){ID=5, Name = "Seetha", AddressID = 0},

            };

            List<Address> Address1 = new List<Address>()
            {
                new Address(){ID = 1, Addressline="first cross"},
                new Address(){ID=2,Addressline="second cross"},
                new Address(){ID=3,Addressline="third cross"},
                new Address(){ID=4,Addressline="forth cross"},
            };

            var res = (from first in Student1
                       from second in Address1
                       select new
                       {
                           Student_Name= first.Name,
                           Address_Line = second.Addressline
                       }).ToList();

            foreach (var val in res)
            {

                Console.WriteLine(" Student ID: {0} , Address : {1}",
                                        val.Student_Name, val.Address_Line);
            }

        }

    }


    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressID { get; set; }

    }
    public class Address
    {
        public int ID { get; set; }
        public string Addressline { get; set; }

    }
}
