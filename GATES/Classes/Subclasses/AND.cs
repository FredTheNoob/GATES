using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace GATES.Type
{
    public class AND : Gate // Vi har vores AND gate til at derive fra gate klassen, på denne måde er vi i stand til at tilgå alle synlige metoder
    {
        // I vores constructor sender vi vores variabler videre til base klassen (Gate)
        public AND(object temp_first, object temp_second, MetroCheckBox temp_outputBit) : base(temp_first, temp_second, temp_outputBit) { }

        // Vi overskriver vores updateGate metode i base klassen. Hvis begge inputs er 1 (sande) samtidigt
        public override void UpdateGate() => GateOutput = input1 && input2;
    }
}
