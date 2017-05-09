using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.AtendeClienteClient consultar = new ServiceReference1.AtendeClienteClient("AtendeClientePort");

            var resultado = consultar.consultaCEP(maskedTextBox1.Text);
            if (resultado != null)
            {
                textBox2.Text = resultado.end;
                textBox3.Text = resultado.cidade;
                textBox4.Text = resultado.bairro;
                textBox5.Text = resultado.complemento;
                textBox6.Text = resultado.uf;


            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
