using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terminal_basicoCS

    internal class Program
    {
        static void Main(string[] args)
        {
        // Neste programa irei fazer a mesma coisa que fiz no java porem utilizando C# 
        // Repositório de referência: https://github.com/Matheus-Assis05/Java-primeiro-projeto-terminal
        // Apenas um teste para ver se a estrutura básica funciona no C#

        while (true)
            {
                Console.Write("->$");
                String input = Console.ReadLine();

                if(input == null)
                {
                    Console.WriteLine("ERROR: No input");
                }else if(input == "test") {
                    Console.WriteLine("you just made a test");
                }else if(input == "quit")
                {
                    break;
                }                
            }
            



            //Impede o programa de fechar imediatamente
            Console.ReadKey();
        }
    }
}
