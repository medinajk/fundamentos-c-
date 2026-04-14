using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio3
    {
        double valor1 = 7.75;
        double valor2 = 3.50;

        public void Operacoes()
        {
            double soma = valor1 + valor2;
            Console.WriteLine(soma);
        }

        public void Subtracao()
        {
            double subtracao = valor1 - valor2;
            Console.WriteLine(subtracao);

        }

        public void Multiplicacao()
        {
            double multiplicacao = valor1 * valor2;
            Console.WriteLine(multiplicacao);
        }

        public void Divisao()
        {
            if(valor2 != 0)
            {
                double divisao = valor1 / valor2;
                Console.WriteLine(divisao);
            }
        }

        public void Media()
        {
            double media = (valor1 + valor2) / 2;
            Console.WriteLine(media);

        }

    }
}
