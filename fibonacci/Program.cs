internal class Program
{
    private static void Main(string[] args)
    {
        double prox = 0, numeroAnterior = 1, numeroAtual;
        int posicao;

        Console.Write("Infome um numero para a sequencia de fibonacci: ");
        posicao = int.Parse(Console.ReadLine());


        for(int i = 0; i < posicao; i++)
        {
            Console.WriteLine(numeroAnterior + prox);
            prox = numeroAnterior + prox;
            numeroAnterior = prox - numeroAnterior;
        }      
    }
}