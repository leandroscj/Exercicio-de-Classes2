using Exercicio_de_classe2;
using System;

namespace Exercicio_de_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionarios f1 = new Funcionarios();
            Funcionarios f2 = new Funcionarios();

            {
                Console.Write("insira seu nome:");
                f1.Nome = Console.ReadLine();

                Console.Write("insira seu Salario:");
                f1.Salario = double.Parse(Console.ReadLine());

                Console.Clear();

                Console.Write("insira seu nome:");
                f2.Nome = Console.ReadLine();

                Console.Write("insira seu salario:");
                f2.Salario = double.Parse(Console.ReadLine());

                double media = ((f1.Salario + f2.Salario) / 2);

                Console.WriteLine($"A média dos dois salários é R$:{media}");
            }
        }
    }
}