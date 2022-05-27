using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Bem vindo a calculadora!");

            Console.WriteLine("Aperte 1 para soma");
            Console.WriteLine("Aperte 2 para subtração");
            Console.WriteLine("Aperte 3 para multiplicação");
            Console.WriteLine("Aperte 4 para divisão");

            int opcao = int.Parse(Console.ReadLine());

            if(opcao == 1)
            {
                Console.Clear();
                Console.WriteLine("Bem vindo a soma, digite seu primeiro número");
                 num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Agora digite o seu segundo número");
                 num2 = int.Parse(Console.ReadLine());
                int resultado = num1 + num2;

                Console.WriteLine("O seu resultado é: " + resultado);

                Console.ReadLine();
            }
            else if(opcao == 2)
            {
                Console.Clear();
                Console.WriteLine("Bem vindo a subtração, digite seu primeiro número");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Agora digite o seu segundo número");
                num2 = int.Parse(Console.ReadLine());
                int resultado = num1 - num2;

                Console.WriteLine("O seu resultado é: " + resultado);
                Console.ReadLine();
            }
            else if(opcao == 3)
            {
                Console.Clear();
                Console.WriteLine("Bem vindo a multiplicação, digite seu primeiro número");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite seu segundo número");
                num2 = int.Parse(Console.ReadLine());

                int resultado = num1 * num2;
                Console.WriteLine("O seu resultado é: " + resultado);
                Console.ReadLine();
            }
            else if(opcao == 4)
            {
                Console.Clear();
                Console.WriteLine("Bem vindo a divisão, digite seu primeiro número");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite seu segundo número");
                num2 = int.Parse(Console.ReadLine());

                int resultado = num1 / num2;
                Console.WriteLine("O seu resultado é: " + resultado);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Operação inválida");
                Console.ReadLine();

            }
            
        }
    }
}
