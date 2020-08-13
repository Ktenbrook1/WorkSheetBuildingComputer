using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingComputerWS
{
    class GPU
    {
        //handles the graphics operations for the computer (primarily for 3D calculations).
        //member variable(has a)
        public string manufacturer;
        public double effectiveMemory;
        //constructor
        public GPU(string manu, double mem)
        {
            this.manufacturer = manu;
            this.effectiveMemory = mem;
        }

        //member methods(can do)
    }
}
