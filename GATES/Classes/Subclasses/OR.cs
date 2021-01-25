using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MetroFramework.Controls;

namespace GATES.Type
{
    class OR : Gate
    {
        public OR(object temp_first, object temp_second, MetroCheckBox temp_outputBit) : base(temp_first, temp_second, temp_outputBit) { }

        // Hvis en af de to gates er 1 (sande)
        public override void UpdateGate() => GateOutput = input1 || input2;
    }
}
