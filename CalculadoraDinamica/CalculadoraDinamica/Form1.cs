using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDinamica{
    public partial class Form1 : Form{
        double total;
        double ultimonumero;
        String operador;
        public Form1(){
            InitializeComponent();
            total = 0;
            ultimonumero = 0;
            operador = "+";
        }
        private void Limpar(){
            total = 0;
            ultimonumero = 0;
            operador = "+";
            txtresultado.Text = "";
        }

        private void gerarnumero(object sender, EventArgs e){
            txtresultado.Text = txtresultado.Text + (sender as Button).Text;//Esse método faz com que qualquer botão faça uma ação
        }

        private void txtresultado_TextChanged(object sender, EventArgs e){
            
        }

        private void operadores(object sender, EventArgs e)
        {

        }
    }
}
