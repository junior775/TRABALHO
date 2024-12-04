using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase para contar o número de palavras:");

        string frase = Console.ReadLine();

        string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int numeroDePalavras = palavras.Length;

        Console.WriteLine($"A frase contém {numeroDePalavras} palavras.");
    }
}