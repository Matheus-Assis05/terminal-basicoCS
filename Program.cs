using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace terminal_basicoCS { 

    internal class Program
    {
        static void Main(string[] args)
        {
            // Neste programa irei fazer a mesma coisa que fiz no java porem utilizando C# 
            // Repositório de referência: https://github.com/Matheus-Assis05/Java-primeiro-projeto-terminal
            // Apenas um teste para ver se a estrutura básica funciona no C#
            /* To Do:
            * - Adicionar os comandos listados em help.  (FEITO)
            * - Criar o submenu "sobre". (FEITO)
            * - Criar uma forma do programa funcionar como um terminal e um comando de quit (FEITO)
            * - Criar a opçâo que permite o usuario consultar a data e hora  (FEITO)
            */

            Console.WriteLine("***************************************************************************************\n" +
                    "Desenvolvido por Matheus Martins usando C# .NET Obviamente Direitos nao Resevados\n" +
                    "Terminal Simples em C# - 27/09/2023\n" + 
                    "***************************************************************************************\n\n" +
                    "  digite 'help' para ver a lista de comandos\n"); 

            //Chamando a calsse menuOpcoes criando um objeto menu
            menuOpcoes menu = new menuOpcoes();

            //while loop para reproduzir multiplos inputs do usuario
            while (true)
            {
                Console.Write("->$ ");
                String input = Console.ReadLine();

                if(input == null) //caso nao haja input
                {
                    Console.WriteLine("ERROR: No input");
                }else if(input == "help") {
                    menu.cmdHelp(); //funcao cmdHelp() da classe menu
                }else if(input == "sobre")
                {
                    menu.cmdSobre();
                }
                else if(input == "versaojava")
                {
                    menu.cmdVerJava("https://github.com/Matheus-Assis05/Java-primeiro-projeto-terminal");
                }
                else if(input == "hora")
                {
                    menu.cmdHora(); 
                }
                else if(input == "quit")
                {
                    Console.WriteLine("Pressione ENTER para sair.");
                    break;
                }                
            }
            



            //Impede o programa de fechar imediatamente
            Console.ReadKey();
        }
    }
}
