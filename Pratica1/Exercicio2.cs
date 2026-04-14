using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio2
    {
        public void NomeSobrenome()
        {
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome");
            string sobrenome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome} {sobrenome}!");
        }
    }
}
