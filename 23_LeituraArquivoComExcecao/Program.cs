using System;
using System.IO; // Necessário para usar File e FileNotFoundException

namespace _23_LeituraArquivoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho completo do arquivo (ex: C:\\temp\\arquivo.txt): ");
            string caminhoArquivo = Console.ReadLine();

            try
            {
                string conteudo = File.ReadAllText(caminhoArquivo);

                Console.WriteLine("\n--- Conteúdo do arquivo ---");
                Console.WriteLine(conteudo);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo não encontrado! Verifique o caminho e tente novamente.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Acesso negado! Você não tem permissão para ler este arquivo.");
            }
            finally
            {
                Console.WriteLine("\nOperação finalizada.");
            }
        }
    }
}
