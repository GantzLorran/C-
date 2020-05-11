using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_POO1
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

        private void button3_Click(object sender, EventArgs e)
        {
            string texto = "Sair da aplicação?";
            string titulo = "FINALIZANDO APLICAÇÃO...";

            if (MessageBox.Show(texto, titulo,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //instancia a classe
            Pessoa p = new Pessoa();
            //passar o conteudo que vai ser digitado para as variaveis
            p.setNome(txtNome.Text);
            try
            {
                p.setIdade(int.Parse(txtIdade.Text));
                //obter o nome e a idade 
                string xnome = p.getNome();
                int xidade = p.getIdade();
                string strSaida = "Nome da Pessoa : " + xnome.ToUpper() + "\n\n" + "Idade : " + xidade.ToString();
                MessageBox.Show(strSaida, "****Resultado****",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message + "\n\n Tente novamente ;(", "**** ERRO DE ENTRADA ****",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
        }
    }
}
