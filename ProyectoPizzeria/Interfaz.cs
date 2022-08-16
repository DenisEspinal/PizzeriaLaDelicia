using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPizzeria
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void LimpiarControles()
        {
            NombreTextBox.Clear();
            TelefonoTextBox.Clear();
            RTNTextBox.Clear();
            TotalTextBox.Clear();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            double cantidad;

            if (GiganteadioButton.Checked == true)
            {
                total = +200;
            }

            if (MedianaRadioButton.Checked == true)
            {
                total = +180;
            }

            if (PequeniaRadioButton.Checked == true)
            {
                total = +160;
            }

            if (ExtraQuesoCheckBox.Checked == true)
            {
                total = total + 80;
            }

            if (PepperoniCheckBox.Checked == true)
            {
                total = total + 110;
            }

            if (CarneCheckBox.Checked == true)
            {
                total = total + 120;
            }

            if (CocaColaCheckBox.Checked == true)
            {
                total = total + 20;
            }

            if (PepsiCheckBox.Checked == true)
            {
                total = total + 20;
            }

            if (AguaCheckBox.Checked == true)
            {
                total = total + 25;
            }

            cantidad = Convert.ToDouble(CantidadNumericUpDown1.Value);
            total = Convert.ToDouble(CantidadNumericUpDown1.Value) * total;

            TotalTextBox.Text = total.ToString();
        }

        private void FacturaButton_Click(object sender, EventArgs e)
        {
            RegistroDataGridView1.Rows.Add(NombreTextBox.Text, TelefonoTextBox.Text, RTNTextBox.Text, TotalTextBox.Text);

            NombreTextBox.Focus();

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
