using System;

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;

        Console.Write("Digite um número inteiro: ");
        numero = int.Parse(Console.ReadLine());

        int anterior = 0;
        int atual = 1;

        while (atual < numero)
        {
            int proximo = anterior + atual;
            anterior = atual;
            atual = proximo;
        }

        if (atual == numero)
        {
            Console.WriteLine("{0} pertence à sequência de Fibonacci.", numero);
        }
        else
        {
            Console.WriteLine("{0} não pertence à sequência de Fibonacci.", numero);
        }
    }
}
