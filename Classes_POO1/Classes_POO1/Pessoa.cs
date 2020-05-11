using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_POO1
{
    class Pessoa
    {
        //Atributos da minha classe
        private string nome;
        private int idade;

        //Métodos
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public int getIdade()
        {
            return idade;
        }
    }
}
