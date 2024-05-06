using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número limite L para calcular a soma dos elementos da série de Fibonacci menores que L:");
        int L = Convert.ToInt32(Console.ReadLine());

        if (L <= 0) // Verifica se o valor inserido pelo usuário é válido
        {
            Console.WriteLine("Por favor, digite um número inteiro positivo maior que zero.");
        }
        else
        {
            int a = 0, b = 1; // Inicializa os dois primeiros números da série de Fibonacci
            int soma = 0; // Variável para armazenar a soma dos elementos

            // Calcula os números da série de Fibonacci até que o próximo número exceda L
            while (a < L)
            {
                soma += a; // Adiciona o número atual à soma
                int temp = a + b; // Calcula o próximo número somando os dois últimos
                a = b; // Atualiza o valor de 'a' para o penúltimo número
                b = temp; // Atualiza o valor de 'b' para o último número calculado
            }

            Console.WriteLine("A soma dos elementos da série de Fibonacci menores que {0} é: {1}", L, soma);
        }
    }
}
