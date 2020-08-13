using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingComputerWS
{
    class Games : Applications
    {
        public int requiredEffectiveMemory;

        public Games()
        {
            ApplicationName = "COD";
            ApplicationType = "Game";
            requiredRAM = 4.0;
            requiredStorage = 0.234;
            requiredEffectiveMemory = 12;
        }
    }
}
