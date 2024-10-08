using System;
using MathNet.Numerics;
using Projeto1;

namespace Extenco
{
    public class Mat()
    {
        public static void RaizQuadra()
        {
            Console.WriteLine("Digite o valor que deseja tirar a raiz quadrada");
            
            double raiz = Convert.ToDouble(Console.ReadLine());
            
            double r2 = Math.Sqrt(raiz);
            Console.WriteLine($"A raiz quadrada de {raiz} é igual a {r2}!");
            Console.WriteLine("___________________________\n");
            
            Projeto1.Program.Menu();
        }
    }
}