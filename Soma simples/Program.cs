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
            float val1, val2, soma;

            Console.WriteLine("Digite um número");
            val1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor");
            val2 = float.Parse(Console.ReadLine());

            soma = val1 + val2;

            Console.WriteLine("A soma dos números é: " + soma);
            Console.ReadLine();
        }
    }
}
