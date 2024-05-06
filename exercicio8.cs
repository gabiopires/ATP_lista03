using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número de elementos da série de Fibonacci que deseja visualizar:");
        int L = Convert.ToInt32(Console.ReadLine());

        // Verifica se o valor inserido pelo usuário é válido
        if (L <= 0)
        {
            Console.WriteLine("Por favor, digite um número inteiro positivo maior que zero.");
        }
        else
        {
            // Inicializa os dois primeiros números da série de Fibonacci
            int a = 0, b = 1;

            // Exibe os dois primeiros números da série
            Console.WriteLine("Os primeiros {0} elementos da série de Fibonacci são:", L);
            Console.Write("{0} {1}", a, b);

            // Calcula e exibe os próximos elementos da série
            for (int i = 2; i < L; i++)
            {
                int temp = a + b; // Calcula o próximo número somando os dois últimos
                Console.Write(" {0}", temp); // Exibe o próximo número
                a = b; // Atualiza o valor de 'a' para o penúltimo número
                b = temp; // Atualiza o valor de 'b' para o último número calculado
            }
            Console.WriteLine(); // Pula uma linha após exibir todos os números da série
        }
    }
}
