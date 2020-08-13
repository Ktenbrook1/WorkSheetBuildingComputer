using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingComputerWS
{
    class MotherBoard
    {
        public string Manufacturer;
        public RAM TemporaryMemory;
        public CPU Processor;
        public Harddrive Storage;
        public GPU Graphics;

        public MotherBoard(string manufacturer, RAM ram, CPU cpu, Harddrive hardDrive, GPU gpu)
        {
            Manufacturer = manufacturer;
            TemporaryMemory = ram;
            Processor = cpu;
            Storage = hardDrive;
            Graphics = gpu;
        }

        
    }
}
