class Program
{
    public static void Main(string[] args)
    {

        double lucros = 1, compra = 0, venda = 0, lucro = 0, lucrodez = 0, lucrodezvinte = 0, lucrovinte = 0, totalcompra = 0, totalvenda = 0;

        while (lucros > 0) //Verifica se o valo é maior que zero para continuar o loop
        {
            Console.Write("Qual o preço de compra ? ");
            compra = double.Parse(Console.ReadLine());

            if (compra == 0) //se o valor digitado for igual a zero o loop para
                break;

            totalcompra += compra; //somando todos os valores digitados em compra, para apresentar o valor total 

            Console.Write("Qual o preço de venda ? ");
            venda = double.Parse(Console.ReadLine());

            totalvenda += venda; //somando todos os valores digitados em venda, para apresentar o valor total 

            if ((venda / compra * 100) < 110) //calcula o valor do lucro para armazenar na variavel de lucros menores que 10%
                lucrodez++;
            else if ((venda / compra * 100) >= 110 && (venda / compra * 100) <= 120) //calcula o valor do lucro para armazenar na variavel de lucros maiores que 10% e menores que 20%
                lucrodezvinte++;
            else if ((venda / compra * 100) > 120) //calcula o valor do lucro para armazenar na variavel de lucros maiores que 20%
                lucrovinte++;
        }

        double totallucro = totalvenda - totalcompra; //calculando o valor total de lucro, subtraindo o total de vendas com o total de compras

        Console.WriteLine("{0} mercadorias proporcionaram lucro menor que 10%, {1} mercadorias proporcionaram lucro entre 10% e 20% e {2} mercadorias proporcionaram lucro maior que 20%", lucrodez, lucrodezvinte, lucrovinte);
        Console.WriteLine("O valor total de vendas foi de: " + totalvenda);
        Console.WriteLine("O valor total de compras foi de: " + totalcompra);
        Console.WriteLine("O total de lucro foi de: " + totallucro);
    }
}
