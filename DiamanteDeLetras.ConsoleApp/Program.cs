using System;

namespace DiamanteDeLetras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] alfabeto = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            Console.Write("Digite uma letra do alfabeto (A - Z): ");
            string letraUsuario = Console.ReadLine().ToUpper();

            string letras = "";
            for (int Z = 0; Z < 26; Z++)
            {
                if (letraUsuario == alfabeto[Z])
                {
                    letras += alfabeto[Z];
                    break;
                }
                else
                {
                    letras += alfabeto[Z];
                }
            }

            int quantidadeEspacosExternos = letras.Length - 1;

            int quantidadeDeX = 1;

            int quantidadeDeLinhas = letras.Length - 1;

            // Parte superior do diamante
            int linha;
            for (linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                for (int i = 0; i < quantidadeEspacosExternos; i++) //escrever os espaços
                {
                    Console.Write(" ");
                }

                for (int i = 1; i <= quantidadeDeX; i++)
                {
                    if (i > 1 && i < quantidadeDeX)
                    {
                        Console.Write(" ");
                        continue;
                    }
                    Console.Write(letras[linha]);
                }

                quantidadeEspacosExternos--;
                quantidadeDeX += 2;

                Console.WriteLine();
            }

            // Parte do meio do diamante
            for (int coluna = 1; coluna <= quantidadeDeX; coluna++)
            {

                if (coluna > 1 && coluna < quantidadeDeX)
                {
                    Console.Write(" ");
                    continue;
                }
                Console.Write(letras[linha]);

            }

            quantidadeEspacosExternos++;
            quantidadeDeX -= 2;

            Console.WriteLine();

            // Parte inferior do diamante
            for (linha = letras.Length - 2; linha < quantidadeDeLinhas; linha--)
            {
                if (linha < 0)
                    break;

                for (int i = 0; i < quantidadeEspacosExternos; i++) //escrever os espaços
                {
                    Console.Write(" ");
                }

                for (int i = 1; i <= quantidadeDeX; i++)
                {
                    if (i > 1 && i < quantidadeDeX)
                    {
                        Console.Write(" ");
                        continue;
                    }
                    Console.Write(letras[linha]);
                }

                quantidadeEspacosExternos++;
                quantidadeDeX -= 2;

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
