using System;
using System.Collections.Generic;
using System.Linq;

namespace Multipledatasource
{

    class Student
    {
        public int Id {get; set;}
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> stud = new List<Student>() 
            {
            new Student() {Id=401, Name="Ramya" },
            new Student() {Id=402, Name="Asha" },
            new Student() {Id=403, Name="Ram" },
            new Student() {Id=404, Name="Rashmi" },
            new Student() {Id=405, Name="Seetha" },
            };

            List<Student> stud2 = new List<Student>() 
            {
            new Student() {Id=401, Name="Ramya" },
            new Student() {Id=402, Name="Asha" },
            new Student() {Id=403, Name="Ram" },
            new Student() {Id=414, Name="Raksh" },
            new Student() {Id=415, Name="Anand" },
            new Student() {Id=416, Name ="Prithvi"},
            };

            var Res = stud.Select(x => new{x.Id, x.Name}).Union(stud2.Select(x=>new { x.Id, x.Name})).ToList();

            foreach(var result in Res)
            {
                Console.WriteLine(result);
            }
            //List<string> datasource1 = new List<string>() { "A", "B", "C", "D" };
            //List<string> datasource2 = new List<string>() { "C", "D", "E", "F" };

            //var res = datasource1.Union(datasource2).ToList();

            //foreach (var Result in res)
            //{
            //    Console.WriteLine(Result);
            //}
        }
    } 
}
