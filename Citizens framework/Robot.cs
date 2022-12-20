using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Citizens_framework
{
    internal class Robot : Citizens
    {
        
        
        private string model;
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
       

    }
}
