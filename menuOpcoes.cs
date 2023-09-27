using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terminal_basicoCS
{
    internal class menuOpcoes
    {
        // Métodos da classe de menu que sao chamados no codigo principal
        public void cmdHelp()
        {
            Console.WriteLine("Comandos: \n" +
            "sobre - Sub-menu de descricao do produto \n" +
            "versaojava - Repositorio no GitHub da versao java deste projeto\n" +
            "hora - Mostra o dia e hora atual\n" +
            "quit - Fecha o programa\n");
        }

        public void cmdSobre()
        {
            Console.WriteLine("Menu Sobre:\n Digite um comando -- nome; lang; desc; voltar");


            //se repete o esquema do while infinito para o usuario realizar varios inputs
            while(true)
            {
                Console.Write("-$> ");
                String inputSobre = Console.ReadLine(); //Recebe na variavel inputSobre o input do usuario do menu sobre

                if (inputSobre == "nome")
                {
                    Console.WriteLine("Desenvovido por: github.com/Matheus-assis05");
                } 
                else if (inputSobre == "lang")
                {
                    Console.WriteLine("C# .NET Console Application - Visual Studio 2022");
                } 
                else if (inputSobre == "desc")
                {
                    Console.WriteLine("Terminal simples com alguns comandos. A finalidade \n" +
                    "do projeto é revisar e fixar a sintaxe e funcionamento C# e aprender sobre classes e importações");
                } 
                else if (inputSobre == "voltar")
                {
                    break; //quebra este while loop  e volta para o anterior
                }
                else
                {
                    Console.WriteLine("ERRO: COMANDO INVÁLIDO");
                }

            }
        }

        public void cmdHora()
        {
            DateTime dthrLocal = DateTime.Now; //recebendo na variavel dthrLocal a hora atual do PC com a funcao DateTime.Now
            
            String dataFormatada = dthrLocal.ToString("dddd, dd/MM/yyyy HH:mm"); //formatando para "dia da semana, dia/mes/ano hora:minuto

            Console.WriteLine(dataFormatada);
        }

        public void cmdVerJava(string url)
        {
            Console.WriteLine("Abrindo o link no navegador padrao...");
            
            try //tenta executar o comando para abrir url
            { 
            System.Diagnostics.Process.Start(url);
            }
            catch(Exception e) //Mostra o usuario se caso houver erro
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
