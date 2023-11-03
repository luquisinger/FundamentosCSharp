class Program
{
    static void Main(string[] args)
    {
            var navegador = new Navegador();

        navegador.NavegarPara("google.cp,");
        navegador.NavegarPara("alura.cp,");
        navegador.NavegarPara("youtubve.cp,");
        navegador.Anterior();
        navegador.Anterior();

        navegador.Proximo();
    }
}

internal class Navegador
{
    private readonly Stack<string> historicoAnterior = new Stack<string>();
    private readonly Stack<string> historicoProximo = new Stack<string>();
    private string atual = "vazia";

    public Navegador()
    {
        Console.WriteLine(atual);      
    }

    internal void Anterior()
    {
        if(historicoAnterior.Any())
        {
            atual = historicoAnterior.Pop();
            Console.WriteLine("pg atual " + atual);
        }
    }

    internal void NavegarPara(string url)
    {
        historicoProximo.Push(atual);
        historicoAnterior.Push(atual);
        atual = url;
        Console.WriteLine("pg atual " + atual);
    }

    internal void Proximo()
    {
        if (historicoProximo.Any())
        {
            historicoAnterior.Push(atual);
            atual = historicoProximo.Pop();
            Console.WriteLine("pg atual " + atual);
        }
    }
}