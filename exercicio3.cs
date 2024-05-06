using System;

class Program
{
    static void Main(string[] args)
    {
        // Variáveis para contar a quantidade de números divisíveis
        int divPor3e9 = 0;
        int divPor2e5 = 0;

        Console.WriteLine("Digite dez números:");

        // Repetição para receber os dez números
        for (int i = 0; i < 10; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            // Verifica se o número é divisível por 3 e 9
            int somaAlgarismos = 0;
            int temp = num;
            while (temp != 0)
            {
                somaAlgarismos += temp % 10;
                temp /= 10;
            }
            if (somaAlgarismos % 3 == 0 && somaAlgarismos != 0)
            {
                Console.WriteLine($"{num} é divisível por 3 e 9");
                divPor3e9++;
            }
            // Verifica se o número é divisível por 2 e 5
            else if (num % 10 == 0 || num % 10 == 2 || num % 10 == 4 || num % 10 == 6 || num % 10 == 8)
            {
                Console.WriteLine($"{num} é divisível por 2 e 5");
                divPor2e5++;
            }
            else
            {
                Console.WriteLine($"{num} não é divisível pelos valores");
            }
        }

        Console.WriteLine($"Quantidade de números divisíveis por 3 e 9: {divPor3e9}");
        Console.WriteLine($"Quantidade de números divisíveis por 2 e 5: {divPor2e5}");
    }
}