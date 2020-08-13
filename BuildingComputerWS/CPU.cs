using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingComputerWS
{
    class CPU
    {
        //member variable(has a)
        public string manufacturer;
        public double effectiveMemory;
        public bool meetsRequirements;
        public MotherBoard mother;
        public Games game;
        //constructor
        public CPU(string manu, double mem)
        {
            this.manufacturer = manu;
            this.effectiveMemory = mem;
        }
        //should have somewhere that if true, it calls the install method
        public void ProcessInstall(Applications applications, Harddrive hardDrive, RAM ram)
        {
            mother.Storage.ApplicationsInHardDrive.Add(applications);
            Console.WriteLine("Install sucessful");
        }
        public bool CheckRequirements(Applications app, Harddrive hardDrive, RAM ram)
        {
            if(mother.TemporaryMemory.totalGigabytes >= app.requiredRAM && mother.Storage.availableStorage >= app.requiredStorage)
            {
                meetsRequirements = true;
            }
            else
            {
                meetsRequirements = false;
                Console.WriteLine("You have {0} storage and {1} RAM", mother.TemporaryMemory.totalGigabytes, mother.Storage.availableStorage);
                Console.WriteLine("This application requires {0} storage and {1} RAM", app.requiredStorage, app.requiredRAM);
            }

            return meetsRequirements;
        }
        public bool CheckRequirementsForGame(Applications app, Harddrive hardDrive, RAM ram)
        {
            if (mother.TemporaryMemory.totalGigabytes >= app.requiredRAM && mother.Storage.availableStorage >= app.requiredStorage
                && mother.Graphics.effectiveMemory >= game.requiredEffectiveMemory)
            {
                meetsRequirements = true;
            }
            else
            {
                meetsRequirements = false;
                Console.WriteLine("You have {0} storage and {1} RAM", mother.TemporaryMemory.totalGigabytes, mother.Storage.availableStorage);
                Console.WriteLine("This application requires {0} storage and {1} RAM", app.requiredStorage, app.requiredRAM);
                Console.WriteLine("This application also requires {0} memory and your memory is {1}", game.requiredEffectiveMemory, mother.Graphics.effectiveMemory);
            }

            return meetsRequirements;
        }

    }
}
