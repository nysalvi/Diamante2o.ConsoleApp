using System;

namespace Diamante2o.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) {
            int parteEsquerda, parteDireita, linha = 0, coluna = 0, tamanho, meio;
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alfabetoChar = alfabeto.ToCharArray();
            char letra;
            while (true) {
                Console.WriteLine("Digite uma letra para fazer o diamante");
                letra = Convert.ToChar(Console.ReadLine().ToUpper());
                if (!char.IsLetter(letra)) {
                    Console.WriteLine("Você deve digitar uma letra outros caracteres são inválidos!!");
                    continue;
                }
                break;
            }
            tamanho = alfabeto.IndexOf(letra) * 2 + 1;
            parteEsquerda = alfabeto.IndexOf(letra) + 1;
            parteDireita = alfabeto.IndexOf(letra) + 1;
            meio = alfabeto.IndexOf(letra);
            while (true) {
                if (coluna == parteEsquerda || coluna == parteDireita) {
                    Console.Write(alfabetoChar[linha]);
                } else {
                    Console.Write(" ");
                }
                if (coluna == tamanho) {
                    Console.WriteLine();
                    coluna = 0;
                    if (linha == meio)
                        break;
                    parteEsquerda--;
                    parteDireita++;
                    linha++;
                    continue;
                }
                coluna++;
            }
            linha--;
            parteEsquerda++;
            parteDireita--;
            while (true) {
                if (coluna == parteEsquerda || coluna == parteDireita)
                    Console.Write(alfabetoChar[linha]);
                else
                    Console.Write(" ");
                if (coluna == tamanho) {
                    Console.WriteLine();
                    if (linha == 0)
                        break;
                    coluna = 0;
                    parteEsquerda++;
                    parteDireita--;
                    linha--;
                    continue;
                }
                coluna++;
            }
            Console.ReadLine();
        }
    }
}
