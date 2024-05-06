class Program
{
    public static void Main(string[] args)
    {
        int votos = 1, candidato1 = 0, candidato2 = 0, candidato3 = 0, candidato4 = 0, nulos = 0, brancos = 0;

        while (votos > 0) //verifica se o valor digitado para votos é maior que 0 para continuar o loop
        {
            Console.Write("Qual o codigo do voto? ");
            votos = int.Parse(Console.ReadLine());

            if (votos == 0) //se o valor digitado para votos for igual a zero, o loop para
                break;
            //verificando cada valor do codigo de votos para armazenar na variavel correta ao que corresponde ao codigo do voto
            else if (votos == 1) 
                candidato1++;
            else if (votos == 2)
                candidato2++;
            else if (votos == 3)
                candidato3++;
            else if (votos == 4)
                candidato4++;
            else if (votos == 5)
                nulos++;
            else if (votos == 6)
                brancos++;
            else
                Console.WriteLine("Digite um codigo valido");
        }
        Console.WriteLine("O candidato 1 recebeu {0} votos", candidato1);
        Console.WriteLine("O candidato 2 recebeu {0} votos", candidato2);
        Console.WriteLine("O candidato 3 recebeu {0} votos", candidato3);
        Console.WriteLine("O candidato 4 recebeu {0} votos", candidato4);
        Console.WriteLine("Tiveram {0} votos nulos", nulos);
        Console.WriteLine("Tiveram {0} votos brancos", brancos);
    }
}
