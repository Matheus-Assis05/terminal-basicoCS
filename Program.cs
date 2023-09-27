using System;
using System.Collections.Generic;
using System.Linq;
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
            * - Adicionar os comandos listados em help. 
            * - Criar o submenu "sobre". 
            * - Criar uma forma do programa funcionar como um terminal e um comando de quit (FEITO)
            * - Criar a opçâo que permite o usuario consultar a data e hora 
            */

            Console.WriteLine("***************************************************************************************\n" +
                    "Desenvolvido por Matheus Martins usando Java 21. Obviamente Direitos nao Resevados\n" +
                    "Terminal Simples em java - 23/09/2023\n" + 
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
                else if(input == "quit")
                {
                    Console.WriteLine("aperte ENTER para sair.");
                    break;
                }                
            }
            



            //Impede o programa de fechar imediatamente
            Console.ReadKey();
        }
    }
}
