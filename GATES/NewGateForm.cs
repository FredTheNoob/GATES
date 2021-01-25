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
    public partial class NewGateForm : MetroForm
    {
        // Vi har to globale referencer, en til vores main form (så vi kan tilgå den overalt i klassen)
        private Form1 main;
        // Vi har også en reference til vores listview, da vi skal have tilføjet til den fra denne form
        private MetroListView lstView;

        // Constructor
        public NewGateForm(Form1 _main, MetroListView _lstView)
        {
            InitializeComponent();
            // Vi sætter det vi får fra vores main form til vores globale referencer
            main = _main;
            lstView = _lstView;
        }

        // Når der trykkes på add knappen
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Vi har en switch der tjekker hvilken type brugeren gerne vil tilføje
            switch (cmbGateType.SelectedItem.ToString())
            {
                // Hvis det er en AND gate
                case "AND":
                    // Lav en ny instans af vores AND klasse. Vi giver klassen den checkbox den skal lave logikken til, vi har første og anden checkbox
                    // Vi bruger vores dictionary og giver vores nøgle med de hårde parenteser [] - på denne måde finder vi de checkboxes som gaten skal sættes til
                    new Type.AND(main.inputs[cmbInputbit.SelectedItem.ToString()], 
                        main.inputs[cmbInputBit2.SelectedItem.ToString()], 
                        main.outputs[cmbOutputbit.SelectedItem.ToString()]);
                    
                    break;

                case "NAND":
                    new Type.NAND(main.inputs[cmbInputbit.SelectedItem.ToString()],
                        main.inputs[cmbInputBit2.SelectedItem.ToString()],
                        main.outputs[cmbOutputbit.SelectedItem.ToString()]);

                    break;

                case "NOR":
                    new Type.NOR(main.inputs[cmbInputbit.SelectedItem.ToString()],
                        main.inputs[cmbInputBit2.SelectedItem.ToString()],
                        main.outputs[cmbOutputbit.SelectedItem.ToString()]);

                    break;

                case "NOT":
                    new Type.NOT(main.inputs[cmbInputbit.SelectedItem.ToString()],
                        main.inputs[cmbInputBit2.SelectedItem.ToString()],
                        main.outputs[cmbOutputbit.SelectedItem.ToString()]);

                    break;

                case "OR":
                    new Type.OR(main.inputs[cmbInputbit.SelectedItem.ToString()],
                        main.inputs[cmbInputBit2.SelectedItem.ToString()],
                        main.outputs[cmbOutputbit.SelectedItem.ToString()]);

                    break;

                case "XNOR":
                    new Type.XNOR(main.inputs[cmbInputbit.SelectedItem.ToString()],
                        main.inputs[cmbInputBit2.SelectedItem.ToString()],
                        main.outputs[cmbOutputbit.SelectedItem.ToString()]);

                    break;

                case "XOR":
                    new Type.XOR(main.inputs[cmbInputbit.SelectedItem.ToString()],
                        main.inputs[cmbInputBit2.SelectedItem.ToString()],
                        main.outputs[cmbOutputbit.SelectedItem.ToString()]);

                    break;
            }

            // Vi tilføjer vores gate til listviewet, så brugeren har overblik over de gates der er tilføjet. 
            // Brugeren kan se gate typen der er tilføjet, samt de input bits den er forbundet til, samt ens output bit
            lstView.Items.Add($"{cmbGateType.SelectedItem} ➜ {cmbInputbit.SelectedItem} ＆ {cmbInputBit2.SelectedItem} ➜ {cmbOutputbit.SelectedItem}");

            // Vi gemmer denne form, for at gå tilbage til vores main form
            this.Hide();
        }

        // Når denne form loader
        private void NewGateForm_Load(object sender, EventArgs e)
        {
            // Vi kører gennem vores dictionary af inputs
            foreach (var item in main.inputs)
            {
                // Vi tilføjer vores controls til vores comboboxes
                cmbInputbit.Items.Add(item.Key);
                cmbInputBit2.Items.Add(item.Key);
            }

            // Vi kører gennem vores dictionary af outputs
            foreach (var item in main.outputs)
            {
                // Vi tilføjer vores controls til vores comboboxes
                cmbOutputbit.Items.Add(item.Key);
            }

            // Vi sætter vores selectedIndex - På denne måde vil en ting fra comboboxen allerede være valgt når formen vises
            cmbGateType.SelectedIndex = 0;
            cmbInputbit.SelectedIndex = 0;
            cmbInputBit2.SelectedIndex = 1;
            cmbOutputbit.SelectedIndex = 0;
        }
    }
}
