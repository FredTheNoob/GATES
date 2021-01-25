using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MetroFramework.Controls;

namespace GATES.Type
{
    class NOT : Gate
    {
        public NOT(object temp_first, object temp_second, MetroCheckBox temp_outputBit) : base(temp_first, temp_second, temp_outputBit) { }

        // Outputter det modsatte af input1
        public override void UpdateGate() => GateOutput = !input1;
    }
}
