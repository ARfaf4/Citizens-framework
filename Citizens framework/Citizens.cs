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
        private List<Pet> pets = new List<Pet>();

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
        public List<Pet> Pets
        {
            get { return pets; }
            set { pets = value; }
        }
    }
}
