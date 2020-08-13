using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingComputerWS
{
    abstract class Applications
    {
        public string ApplicationName;
        public string ApplicationType;
        public double requiredRAM;
        public double requiredStorage;

        public Applications()
        {
            ApplicationName = "Slack";
            ApplicationType = "Messaging Service";
            requiredRAM = 4.0; // in gigs
            requiredStorage = 0.512; //in gigs
        }
    }
}
