using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exercicio4
    {

        public void LerCaracteres()
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();
            int caracteres = frase.Length;
            Console.WriteLine("A frase digitada possui " + caracteres + " caracteres.");
        }

    }
}
