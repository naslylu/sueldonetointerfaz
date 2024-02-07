using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sueldonetointerfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void btn_CalcularSueldo_Click_1(object sender, EventArgs e)
        {
            try
            {
                double PagoHoras = Convert.ToDouble(txt_PagoHoras.Text);
                double HorasTrabajadas = Convert.ToDouble(txt_HorasTrabajadas.Text);

                double SueldoBruto = PagoHoras * HorasTrabajadas;

                double AFP = SueldoBruto * 0.0287;
                double SFS = SueldoBruto * 0.0304;

                double TotalDesc = AFP + SFS;

                double SueldoNeto = SueldoBruto - TotalDesc;

                lblSueldoBruto.Text = SueldoBruto.ToString("C");
                lblAFP.Text = AFP.ToString("C");
                lblSFS.Text = SFS.ToString("C");
                lblTotalDesc.Text = TotalDesc.ToString("C");
                lblSueldoNeto.Text = SueldoNeto.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
