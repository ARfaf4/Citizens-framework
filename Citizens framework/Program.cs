using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Citizens_framework
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Citizens citizens = new Citizens();
            string line1 = "a";
            int age = 0;
            

            while (line1 != "End")
            {
                Console.WriteLine("Do u want to end");
                line1 = Console.ReadLine();
                Console.WriteLine("Name id age");
                var line = Console.ReadLine(); 
                string[] vars = line.Split(' '); //
                int id = int.Parse(vars[1]);
                string name = vars[0];
                string model = vars[0];
                age = int.Parse(vars[2]);
                
                if (age != 0)
                {
                    Person person = new Person();
                    person.Id = id;
                    person.Name = name;
                    person.Age = age;
                    citizens.Persons.Add(person);
                }
                else 
                {
                    Robot robot = new Robot();
                    robot.Id = id;
                    robot.Model = model;
                    citizens.Robots.Add(robot);
                }
                
            }
            int fakeidnumbers = int.Parse(Console.ReadLine());
            int fakenumberslenght = fakeidnumbers.ToString().Length;
            citizens.Checker(fakeidnumbers, fakenumberslenght);
            foreach (var item in citizens.Persons)
            {
                Console.WriteLine(item);
            }
            foreach (var item in citizens.Robots)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
        
    }
}
