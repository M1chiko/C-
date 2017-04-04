using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string operace = operaceComboBox.SelectedItem.ToString();
            double c1 = Convert.ToDouble(cislo1.Value);
            double c2 = Convert.ToDouble(cislo2.Value);
            double vysledek = 0;

            if (operace == "+")
                vysledek = c1 + c2;
            else if (operace == "-")
                vysledek = c1 - c2;
            else if (operace == "*")
                vysledek = c1 * c2;
            else if (operace == "/")

                if (c2 != 0)
                    vysledek = c1 / c2;
                else
                    MessageBox.Show("Nulou nelze dělit");
            
            vysledekLabel.Text = vysledek.ToString();
            
            
        }
    }
}
