using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingComputerWS
{
    class Harddrive
    {
        //member variable(has a)
        public double totalStorage;
        public double availableStorage;
        public List<Applications> ApplicationsInHardDrive;

        //constructor
        public Harddrive(double tStorage, double aStorage)
        {
            this.totalStorage = tStorage;
            this.availableStorage = aStorage;
        }

        //member methods(can do)
    }
}
