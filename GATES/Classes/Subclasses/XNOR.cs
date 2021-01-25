using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MetroFramework.Controls;

namespace GATES.Type
{
    class XNOR : Gate
    {
        public XNOR(object temp_first, object temp_second, MetroCheckBox temp_outputBit) : base(temp_first, temp_second, temp_outputBit) { }

        // Hvis begge er 0 eller 1, men ikke at de individuelt er 1
        public override void UpdateGate() => GateOutput = (input1 && input2) || (!input1 && !input2);
    }
}
