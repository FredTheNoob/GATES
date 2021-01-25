using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace GATES
{
    public class Gate
    {
        public bool input1 = false;
        public bool input2 = false;
        
        // Vi har en intern reference til vores første input. Vi har at gøre med typen object, da vi både kan parse en checkbox men også en gate
        private object referenceToFirstInput;
        // Vi har en intern reference til vores andet input
        private object referenceToSecondInput;
        // Denne bool fortæller hvorvidt vi skal tjekke vores checkbox eller ej. 
        public bool GateOutput;
        // En reference til vores checkbox som vi enten skal tjekke eller ikke tjekke
        private MetroCheckBox outputBit;

        // Den liste indeholder alle vores gates som bliver oprettet i form1_load
        public static List<Gate> gateList = new List<Gate>();

        // Dette er gate klassen constructor. Dette er en slags setup metode der køres for at opsætte klassen
        public Gate(object temp_first, object temp_second, MetroCheckBox temp_outputBit)
        {
            // Vi sætter vores interne variabler til dem vi får når klassen konstrueres
            referenceToFirstInput = temp_first;
            referenceToSecondInput = temp_second;
            outputBit = temp_outputBit;

            // Vi tilføjer gaten til vores liste
            gateList.Add(this);
        }

        // Denne metode er en virtuel metode, som vi kan overskrive (overwrite) fra vores subclasses
        public virtual void UpdateGate() { }

        // Denne metode står for at opdatere vores gates, den finder også gate typen og bestemmer derfra hvilken checkbox der skal tjekkes
        public void Update()
        {
            // Da vi spørger efter et object skal vi tjekke hvad det er vi har modtaget, enten om vi har modtaget en checkbox til inputs eller en gate
            if (referenceToFirstInput.GetType() == typeof(MetroCheckBox))
            {
                // Vi caster vores reference til en metrocheckbox
                MetroCheckBox first_converted = (MetroCheckBox)referenceToFirstInput;
                // Vi sætter vores første input til vores checkbox
                input1 = first_converted.Checked;
            }
            // Hvis objectet er en gate
            else if (referenceToFirstInput.GetType() == typeof(Gate))
            {
                Gate first_converted = (Gate)referenceToFirstInput;
                input1 = first_converted.GateOutput;
            }

            // Hvis der er et second input
            if (referenceToSecondInput != null)
            {
                if (referenceToSecondInput.GetType() == typeof(MetroCheckBox))
                {
                    MetroCheckBox second_converted = (MetroCheckBox)referenceToSecondInput;
                    input2 = second_converted.Checked;
                }
                else if (referenceToSecondInput.GetType() == typeof(Gate))
                {
                    Gate second_converted = (Gate)referenceToSecondInput;
                    input2 = second_converted.GateOutput;
                }
            }
            // Vi kalder vores UpdateGate som i de andre klasser vil indeholde logikken bag hver gate
            UpdateGate();
            // Hvis vores outputBit er sat tjekker vi vores checkbox
            if (outputBit != null) outputBit.Checked = GateOutput;
        }

        // Denne metode opdaterer vores gates som er i vores liste
        public static void updateAllGates()
        {
            // Vi looper igennem vores liste af gates
            foreach (Gate gate in gateList)
            {
                // Vi opdaterer alle gates i vores liste "gateList"
                gate.Update();
            }
        }
    }
}
