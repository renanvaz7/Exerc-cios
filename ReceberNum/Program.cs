using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceberNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int resp = 0;
            int memo = 0;
            while (true)
            {                                 
                string resposta = ("sim");
                while (resposta.Equals("sim"))
                {
                    Console.WriteLine("Digite um número");
                    resp = int.Parse(Console.ReadLine());
                    Console.WriteLine("Deseja continuar?");
                    resposta = Console.ReadLine();
                }
                if (resp > memo)
                {
                    memo = resp;
                }
                Console.WriteLine("O maior valor é: " + b);
            }
            Console.ReadLine();
        }
    }
}
