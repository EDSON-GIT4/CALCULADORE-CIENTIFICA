using System;
using MathNet.Numerics;
using Extenco;
using tabuada;

namespace Projeto1
{
    public class Program
    {
        static void Main(string[] argumento)
        {
            Console.Clear();
            Console.WriteLine("OLÁ, BEM VINDO A CALCULADORA!!");
            Console.WriteLine("===============================");
            Menu();
            
        }
        public static void Menu()
        {
            Console.WriteLine("O que deseja fazer?:\n 1 SOMA \n 2 SUBTRAÇÃO \n 3 DIVISÃO \n 4 MULTIPLICAÇÃO\n 5 FATORIAL");
            Console.WriteLine(" 6 RAIZ QUADRADA\n ");

            Console.WriteLine("-----------------------------");

            Console.WriteLine("Selecione Uma das opções acima:");
            
            byte select = Convert.ToByte(Console.ReadLine());

            switch (select)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Fatorial(); break;
                case 6: Extenco.Mat.RaizQuadra(); break;
                case 7: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("   +   ");

            Console.WriteLine("Segundo valor:");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            double resultado = valor1 + valor2;
            Console.WriteLine($"Resultado da soma : {resultado} !");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("   -   ");

            Console.WriteLine("Segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            double resultado = valor1 - valor2;
            Console.WriteLine($"Resultado de subtração : {resultado} !");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("   /   ");

            Console.WriteLine("Segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            double resultado = valor1 / valor2;
            Console.WriteLine($"Resultado da divisão : {resultado} !");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("   *   ");

            Console.WriteLine("Segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            double resultado = valor1 * valor2;
            Console.WriteLine($"Resultaado de multiplicação : {resultado}");
            Console.ReadKey(); 
            Menu();
        }

        static void Fatorial()
        {
            Console.Clear();
            Console.WriteLine("Digite o número que você deseja calcuar a fatorial: ");

            int val = Convert.ToInt32(Console.ReadLine());
            double fat = SpecialFunctions.Factorial(val);
            Console.WriteLine(fat);
            Menu();
        }
    }
}