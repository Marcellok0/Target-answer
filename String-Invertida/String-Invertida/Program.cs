using System;
using System.Windows.Input;

class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo keyInfo;

        do
        {
            Console.WriteLine("Digite uma palavra:");
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            int length = charArray.Length;

            for (int i = 0; i < length / 2; i++)
            {
                char temp = charArray[i];
                charArray[i] = charArray[length - i - 1];
                charArray[length - i - 1] = temp;
            }

            string output = new string(charArray);
            Console.WriteLine("Palavra invertida: " + output);
            Console.WriteLine("");

            Console.WriteLine("Pressione Esc para sair ou qualquer outra tecla para continuar...");
            keyInfo = Console.ReadKey();
            Console.WriteLine();
        } while (keyInfo.Key != ConsoleKey.Escape);
    }
}
