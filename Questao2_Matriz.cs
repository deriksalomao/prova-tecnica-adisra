using System;

// Renomeei a classe para evitar conflito com os outros arquivos do projeto
public class Questao2_Matriz
{
    // Função que recebe a matriz e as dimensões para contar pares e ímpares
    public static int ObterMaiorOcorrencia(int[,] matriz, int linhas, int colunas)
    {
        int contagemPares = 0;
        int contagemImpares = 0;

        // Navega pelas linhas
        for (int i = 0; i < linhas; i++)
        {
            // Navega pelas colunas
            for (int j = 0; j < colunas; j++)
            {
                // Se o resto da divisão por 2 for zero, o número é par
                if (matriz[i, j] % 2 == 0)
                {
                    contagemPares++;
                }
                else
                {
                    contagemImpares++;
                }
            }
        }

        // Retorna a maior quantidade de ocorrências encontrada
        return Math.Max(contagemPares, contagemImpares);
    }

    // Método Main para permitir o teste individual deste arquivo
    public static void Main()
    {
        // Exemplo de teste: Matriz 3x3
        int[,] minhaMatriz = {
            { 1, 2, 3 }, // 1 par (2), 2 ímpares (1,3)
            { 4, 5, 6 }, // 2 pares (4,6), 1 ímpar (5)
            { 8, 10, 12 } // 3 pares (8,10,12), 0 ímpares
        };

        // Total: 6 pares e 3 ímpares. O retorno esperado é 6.
        int resultado = ObterMaiorOcorrencia(minhaMatriz, 3, 3);

        Console.WriteLine($"A maior quantidade de ocorrências encontrada foi: {resultado}");
    }
}