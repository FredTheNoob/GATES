using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace GATES
{
    public partial class Form1 : MetroForm
    {
        // Vi laver en reference til vores newGateForm. Vi deklarerer den i toppen, 
        //eftersom at vi gerne vil være i stand til at tilgå den overalt i denne klasse
        private NewGateForm newGateForm;

        // Vi laver to nye dictionaries som indeholder vores input og output control navne
        public Dictionary<string, MetroCheckBox> inputs;
        public Dictionary<string, MetroCheckBox> outputs;

        public Form1()
        {
            InitializeComponent();

            // Vi laver en ny instans af vores form klasse, vi parser formen, samt vores listbox til den anden form, da den skal bruge det
            newGateForm = new NewGateForm(this, metroListView1);

            // Vi laver instanser af vores dictionaries, den tager en string som nøgle når vi skal tilgå dem senere, og en checkbox som er vores værdi 
            inputs = new Dictionary<string, MetroCheckBox>();
            outputs = new Dictionary<string, MetroCheckBox>();

            // Vi kører gennem hele vores groupbox af input controls som indeholder checkboxe
            foreach (MetroCheckBox item in grpInputs.Controls)
            {
                // Vi tilføjer hver input control til vores dictionary
                inputs.Add(item.Name, item);
            }

            // Vi kører gennem hele vores groupbox af output controls som indeholder checkboxe 
            foreach (MetroCheckBox item in grpOutputs.Controls)
            {
                outputs.Add(item.Name, item); // Vi tilføjer hver input control til vores dictionary
            }
        }
        
        // Når formen loader
        private void Form1_Load(object sender, EventArgs e)
        {
            // Vi opdaterer alle gates, efter at vi har oprettet vores gates. På denne måde viser de det rigtige stadie fra start
            Gate.updateAllGates();
        }

        // Når der trykkes på en gate
        private void Gates_Click(object sender, EventArgs e)
        {
            Gate.updateAllGates();
        }

        // Når der trykkes på new gate knappen
        private void btnNewGate_Click(object sender, EventArgs e)
        {
            // Vis vores new gate form
            newGateForm.Show();
        }
    }
}
