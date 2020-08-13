using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingComputerWS
{
    class Computer
    {
        CPU cpu;
        GPU gpu;
        Harddrive drive;
        MotherBoard board;
        RAM ram;
        Applications applications;
        public Computer()
        {
            cpu = new CPU("DELL", 16.0);
            gpu = new GPU("gigabyte", 5.0);
            drive = new Harddrive(4.0, 6.0);
            ram = new RAM(16, "G.skill");
            board = new MotherBoard(cpu.manufacturer, ram, cpu, drive, gpu);
            Console.WriteLine(cpu.manufacturer, cpu.effectiveMemory, gpu.manufacturer, board.Processor);
        }

    }
}
