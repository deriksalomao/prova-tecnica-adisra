using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a posição desejada (ex: 0, 1, 2...): ");

        if (int.TryParse(Console.ReadLine(), out int posicao) && posicao >= 0)
        {
            // Usei o 'long' pois o número cresce de forma muito rápida 
            long resultado = CalcularFibonacci(posicao);
            Console.WriteLine($"O número da sequência na posição {posicao} é: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro maior ou igual a zero.");
        }
    }

    static long CalcularFibonacci(int n)
    {
        // Casos base definidos
        if (n == 0) return 0;
        if (n == 1) return 1;

        long anterior = 0;
        long atual = 1;
        long proximo;

        // O laço começa na posição 2 e vai até a posição solicitada (n)
        for (int i = 2; i <= n; i++)
        {
            proximo = anterior + atual; // A soma dos dois precedentes
            anterior = atual;           // O atual vira o anterior para o próximo ciclo
            atual = proximo;            // O próximo vira o atual
        }

        return atual;
    }
}