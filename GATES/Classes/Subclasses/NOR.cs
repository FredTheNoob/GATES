using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MetroFramework.Controls;

namespace GATES.Type
{
    class NOR : Gate
    {
        public NOR(object temp_first, object temp_second, MetroCheckBox temp_outputBit) : base(temp_first, temp_second, temp_outputBit) { }

        // Hvis de begge er 1 eller individuelt 1, men ikke at begge er 0
        public override void UpdateGate() => GateOutput = !input1 || !input2;
    }
}
