using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5___Calculos{
    class Aula5
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double res = 0;
            String operacao = "";
            Console.WriteLine("Digite o primeiro número: ");//Comando para digitar na tela
            numero1 = Convert.ToDouble(Console.ReadLine());//Comando para ler o que foi digitado

            Console.WriteLine("Digite o segundo número: ");//Comando para digitar na tela
            numero2 = Convert.ToDouble(Console.ReadLine());//Comando para ler o que foi digitado

            switch (operacao){
                case "+": res = numero1 + numero2;
                    break;
                case "-": res = numero1 - numero2;
                    break;
                case "*": res = numero1 * numero2;
                    break;
                case "/": res = numero1 / numero2;
                    break;
            }
            /*Console.WriteLine("Escolha o operação + - * / ");
            operacao = Console.ReadLine();
            if (operacao == "+")
            {
                res = numero1 + numero2;// Faz a Soma dos dois números que foram digitados
            }
            if (operacao == "-")
            {
                res = numero1 - numero2;// Faz a Subtração dos dois números que foram digitados
            }
            if (operacao == "*")
            {
                res = numero1 * numero2;// Faz a Multiplicação dos dois números que foram digitados
            }
            if (operacao == "/")
            {
                res = numero1 / numero2;// Faz a Divisão dos dois números que foram digitados
            }
            Console.WriteLine("O resultado dos números são: " + res);//Mostra na tela o resultado
            Console.ReadKey();//Pausa a tela para que ela não feche*/
        }
    }
}
