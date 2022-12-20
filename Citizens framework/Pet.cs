using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Citizens_framework
{
    internal class Pet : Citizens
    {
        string name;
        string birthdate;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
    }
}
