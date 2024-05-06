using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor inteiro e positivo para N:");
        int n = int.Parse(Console.ReadLine());

        int e = 1, fatorial = 1;

        if (n < 0) // Verifica se o número inserido é negativo
        {
            Console.WriteLine("Não é possível calcular o fatorial de números negativos.");
        }
        else // Se o número inserido for positivo ou zero, calcula o valor de E
        {

            for (int i = 1; i <= n; i++)
            {
                fatorial *= i; // Calcula o fatorial de i
                e += 1 / fatorial; // Adiciona 1/fatorial ao valor de E
            }

        }
        Console.WriteLine("O valor de E é: " + e);
    }
}

