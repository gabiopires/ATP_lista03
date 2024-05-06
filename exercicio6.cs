using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main(string[] args)
    {

        double salario = 1, filhos = 0, mediasa = 0, contsa = 0, mediafi = 0, contfi = 0, maiorsalario = 0, salariocem = 0, percentual = 0;

        while (salario > 0) //Repetição enquanto o numero foi maior que zero
        {
            Console.Write("Qual seu salario? ");
            salario = double.Parse(Console.ReadLine());

            if (salario < 0) //Se for um numero negativo ele para o loop
                break;

            mediasa += salario; //adiciona os valores em uma variavel para cancular a media depois
            contsa++;

            if (maiorsalario < salario) //Verifica se o valor inserido é maior que o antigo, se for ele guarda o valor maior
                maiorsalario = salario;

            if (salario <= 100) //Armazena os valores abaixo de 100
                salariocem++;

            Console.Write("Quantidade de filhos? ");
            filhos = double.Parse(Console.ReadLine());

            mediafi += filhos; //adiciona os valores em uma variavel para cancular a media depois
            contfi++;
        }
            //calculos das medias 
            double mediasalario = mediasa / contsa;
            double mediafilhos = mediafi / contfi;
        
            percentual = ((double)salariocem / contsa) * 100; //calculo do percentual de numeros menores que 100

        Console.WriteLine("A media do salario é " + mediasalario.ToString("F2"));
        Console.WriteLine("A media de filhos é " + mediafilhos.ToString("F2"));
        Console.WriteLine("O maior salario é " + maiorsalario.ToString("F2"));
        Console.WriteLine("O percentual de pessoas com salário até R$ 100,00 é " + percentual.ToString("F2") + "%");
    }
}