using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_e_Menor_ou_Igual
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (count<11)
            {
                int a;
                int b=0;
                Console.WriteLine("Digite um número");
                a = int.Parse(Console.ReadLine());
                
                if (a > b)
                {
                    b = a;
                }
                Console.WriteLine("O maior valor é: " + b);
                
                count++;
            }
            Console.ReadLine();
        }
    }
}
