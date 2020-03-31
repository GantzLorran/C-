using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carregamentos_de_imagens{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){

        }

        private void button1_Click(object sender, EventArgs e){
            if (openFileDialog1.ShowDialog() == DialogResult.OK){
                textBox1.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
