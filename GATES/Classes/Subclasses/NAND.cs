using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MetroFramework.Controls;

namespace GATES.Type
{
    class NAND : Gate
    {
        public NAND(object temp_first, object temp_second, MetroCheckBox temp_outputBit) : base(temp_first, temp_second, temp_outputBit) { }

        // Hvis begge er 0 eller en af de to inputs er 1
        public override void UpdateGate() => GateOutput = !input1 && !input2;
    }
}
