using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario(textBox1.Text, float.Parse(textBox2.Text), float.Parse(textBox3.Text), float.Parse(textBox4.Text));

            if (checkBox1.Checked == true)
            {
                textBox5.Text = f.nome + "R$" + Convert.ToString(f.CalculaLiquido(float.Parse(textBox2.Text), float.Parse(textBox4.Text)));

            }
            else
            {
               textBox5.Text = f.nome + "R$" + Convert.ToString(f.CalculaLiquido(float.Parse(textBox2.Text), float.Parse(textBox3.Text), float.Parse(textBox4.Text)));

            }
        }
    }
}
