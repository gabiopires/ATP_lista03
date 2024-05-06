class Program
{
    public static void Main(string[] args)
    {

        int numero = 0, positivos = 0, negativos = 0, zeros = 0;
        string parar;

        do
        {
            Console.Write("Digite um numero ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
                positivos++;
            if (numero < 0)
                negativos++;
            if (numero == 0)
                zeros++;

            Console.Write("Quer adicionar mais um numero? (S/N) ");
            parar = Console.ReadLine();
        }

        while (parar is "S" or "s");

        Console.Write("Você digitou {0} numeros positivos, {1} numeros negativos e {2} numero zeros", positivos, negativos, zeros);
    }

}