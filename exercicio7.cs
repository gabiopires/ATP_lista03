using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um valor inteiro e positivo: ");
        double n = double.Parse(Console.ReadLine());

        double s = 1;

        if (n < 0) // Verifica se o número inserido é negativo
        {
            Console.WriteLine("Não é possível calcular números negativos.");
        }
        else
        {
                for (int i = 1; i <= n; i++) // Se o número inserido for positivo ou zero, calcula a soma dos termos
            {
                    double termo = 1.0 / i; // Calcula o termo atual da série
                    s += termo; // Adiciona o termo atual à soma total
                    Console.WriteLine("Termo {0}: {1}", i, termo); // Exibe o termo atual e seu valor
            }
                Console.WriteLine("Valor final de S: {0}", s);
            }

        }
    }

