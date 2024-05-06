using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Você quer o fatorial de qual número?");
        int n = int.Parse(Console.ReadLine());

        int fatorial = 1;

        if (n < 0) // Verifica se o número inserido é negativo
        {
            Console.WriteLine("Não é possível calcular o fatorial de números negativos.");
        }
        else if (n == 0 || n == 1)  // Verifica se o número inserido é 0 ou 1
        {
            Console.WriteLine("O fatorial de " + n + " é 1");
        }
        else // Se o número inserido for positivo e diferente de 0 ou 1
        {
            for (int i = n; i != 0; i--) // Calcula o fatorial usando um loop for
            {
                fatorial *= i; // Multiplica o fatorial pelo valor de i em cada iteração
            }

            Console.WriteLine("O fatorial de " + n + " é " + fatorial);
        }
    }
}
