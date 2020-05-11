using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    class Funcionario
    {
        public string nome;
        public float salario, descontos, adicionais;

        public Funcionario(string n, float s, float d, float a)
        {
            this.nome = n;
            this.salario = s;
            this.descontos = d;
            this.adicionais = a;
        }
        public float CalculaLiquido(float s, float d, float a)
        {
            return(s - d) + a;
        }
        public float CalculaLiquido(float s, float a)
        {
            return s + a;
        }
    }
}
