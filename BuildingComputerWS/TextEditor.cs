using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingComputerWS
{
    class TextEditor : Applications
    {
        public TextEditor()
        {
            ApplicationName = "Microsoft Word";
            ApplicationType = "Text Editor";
            requiredRAM = 2.0;
            requiredStorage = 0.012;
        }
    }
}
