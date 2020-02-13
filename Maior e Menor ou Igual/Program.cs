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
                int resp, memo = 0;
                Console.WriteLine("Digite um número");
                resp = int.Parse(Console.ReadLine());
                
                if (resp > memo)
                {
                    memo = resp;
                }
                Console.WriteLine("O maior valor é: " + memo);
                
                count++;
            }
            Console.ReadLine();
        }
    }
}
