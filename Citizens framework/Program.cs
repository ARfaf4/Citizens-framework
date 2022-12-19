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
            string name;
            uint id;
            uint age;
            var ids = new List<uint>();

            while (list1.Count != 1 && list1[0] != "end")
            {
                if (list1.Count == 2)
                {
                    name = list1[0];
                    id = uint.Parse(list1[1]);
                    ids.Add(id);

                }
                else if (list1.Count == 3)
                {
                    name = list1[0];
                    age = uint.Parse(list1[2]);
                    id = uint.Parse(list1[1]);
                    ids.Add(id);
                }
                input = Console.ReadLine();
                list1 = input.Split(' ').ToList();
            }
            if (list1[0] == "end")
            {
                uint checkedNumber = uint.Parse(Console.ReadLine());
                foreach (var idnumber in ids)
                {
                    string parsed = idnumber.ToString();
                    if (parsed.EndsWith(checkedNumber.ToString()))
                    {
                        Console.WriteLine(idnumber);
                    }
                }
            }
            Console.ReadKey();
        }
        
    }
}
