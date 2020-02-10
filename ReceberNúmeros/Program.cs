using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceberNúmeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "0";
            while (resposta.Equals("sim"))
            {
                int n;
                int b = 0;
                int i;
                for (i = 0; i < 2; i++)
                {
                    Console.WriteLine("Digite um número");
                    n = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Deseja Finalizar?");
                    resposta = Console.ReadLine();
                                        
                }
                if (n > b)
                {
                    b = n;
                }
                Console.WriteLine("O maior valor é: " + n);
            }                   
                      
        }
    }
}
