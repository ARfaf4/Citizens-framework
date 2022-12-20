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
            string input = Console.ReadLine();
            var list1 = input.Split(' ').ToList();
            Citizens citizens = new Citizens();

            while (list1.Count != 1 && list1[0] != "end")
            {
                if (list1[0] == "Robot")
                {
                    Robot robot = new Robot()
;                   robot.Model = list1[1];
                    robot.Id = list1[2];
                    citizens.Robots.Add(robot);                    

                }
                else if (list1[0] == "Citizen")
                {
                    Person person = new Person();
                    person.Name = list1[1];
                    person.Age = int.Parse(list1[2]);
                    person.Id = list1[3];
                    person.Birthdate = list1[4];
                    citizens.Persons.Add(person);
                }
                else if (list1[0] == "Pet")
                {
                    Pet pet = new Pet();
                    pet.Name = list1[1];
                    pet.Birthdate = list1[2];
                    citizens.Pets.Add(pet);
                }
                input = Console.ReadLine();
                list1 = input.Split(' ').ToList();
            }
            if (list1[0] == "end")
            {
                int bdnumber = int.Parse(Console.ReadLine());
                foreach (Person person in citizens.Persons)
                {
                    string bd = person.Birthdate.ToString();
                    if (bd.EndsWith(bdnumber.ToString()))
                    {
                        Console.WriteLine(person.Name + " " + person.Birthdate);
                    }
                }
                foreach (Pet pet in citizens.Pets)
                {
                    string bd = pet.Birthdate.ToString();
                    if (bd.EndsWith(bdnumber.ToString()))
                    {
                        Console.WriteLine(pet.Name + " " + pet.Birthdate);
                    }
                }
            }
            Console.ReadKey();
        }
        
    }
}
/*
         int checkedNumber = int.Parse(Console.ReadLine());
         foreach (Person person in citizens.Persons)
         {
             string parsed = person.Id.ToString();
             if (parsed.EndsWith(checkedNumber.ToString()))
             {
                 Console.WriteLine(person.Id);
             }
         }
         foreach (Robot robot in citizens.Robots)
         {
             string parsed = robot.Id.ToString();
             if (parsed.EndsWith(checkedNumber.ToString()))
             {
                 Console.WriteLine(robot.Id);
             }
         }
*/