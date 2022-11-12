using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citizens_framework
{
    internal class Citizens
    {
        private List<Person> persons = new List<Person>();
        private List<Robot> robots = new List<Robot>();
       
        public List<Person> Persons
        {
            get { return persons; }
            set { persons = value; }
        }
        public List<Robot> Robots
        {
            get { return robots; }
            set { robots = value; }
        }
        public void Checker(int fakeid1, int fakelenght)
        {
            foreach (var item in Persons)
            {
                int ids = item.Id.ToString().Length - fakelenght;
                if (ids == fakeid1)
                {
                    item.Persons.Remove(item);
                }
            }
            foreach (var item in Robots)
            {
                int ids = item.Id.ToString().Length - fakelenght;
                if (ids == fakeid1)
                {
                    item.Robots.Remove(item);
                }
            }
        }
    }
}
