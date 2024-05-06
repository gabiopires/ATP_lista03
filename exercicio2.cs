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

        double soma = positivos + negativos + zeros;
        double porcentagempo = positivos / soma * 100;
        double porcentagemneg = negativos / soma * 100;
        double porcentagemze = zeros / soma * 100;

        Console.Write("Você digitou {0} ({1}%) numeros positivos, {2} ({3}%) numeros negativos e {4} ({5}%) numeros zeros", positivos, porcentagempo.ToString("F2"), negativos, porcentagemneg.ToString("F2"), zeros, porcentagemze.ToString("F2"));
    }

}