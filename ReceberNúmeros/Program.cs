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
                int cont=1;                
                int[] N = new int[cont];
                //int n;
                //int b = 0;
                int i;
                for (i = 0; i < cont; i++)
                {
                    Console.WriteLine("Digite um número");
                    N[i] = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Deseja Finalizar?");
                    resposta = Console.ReadLine();
                                        
                }                
               //Console.WriteLine("O maior valor é: " + n);
                cont++;
            }                   
                      
        }
        
    }
}
