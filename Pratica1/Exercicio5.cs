using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio5
    {

        public static bool ValidarPlaca(string placa)
        {
            if (placa.Length !=7)
                return false;

            for (int i = 0; i < 3; i++)
            {
                if (!char.IsLetter(placa[i]))
                {
                    Console.WriteLine("A placa " + placa + " é inválida.");
                    return false;
                }
            }

            for (int i = 3;i < 7; i++)
            {
                if (!char.IsDigit(placa[i]))
                {
                    Console.WriteLine("A placa " + placa + " é inválida.");
                    return false;
                }
            }
            Console.WriteLine("A placa " + placa + " é válida.");
            return true;
            
        }

    }
}
