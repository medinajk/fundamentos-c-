using System;

namespace ConsoleApp1
{
    internal class Exercicio6
    {
        public static void DataAtual()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Formato completo:");
            Console.WriteLine(now.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss"));

            Console.WriteLine("\nApenas a data:");
            Console.WriteLine(now.ToString("dd/MM/yyyy"));

            Console.WriteLine("\nApenas a hora:");
            Console.WriteLine(now.ToString("HH:mm:ss"));

            Console.WriteLine("\nData com mês por extenso:");
            Console.WriteLine(now.ToString("dd 'de' MMMM 'de' yyyy"));
        }
}
}
