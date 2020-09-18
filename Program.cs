using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}");
            Console.ReadKey();
        }
    }
}
