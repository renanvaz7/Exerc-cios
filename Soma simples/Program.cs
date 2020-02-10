using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;

            Console.WriteLine("Digite um número");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor");
            b = float.Parse(Console.ReadLine());

            c = a + b;

            Console.WriteLine("A soma dos números é: " + c);
            Console.ReadLine();
        }
    }
}
