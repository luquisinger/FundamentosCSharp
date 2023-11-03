class program
{
    static Queue<string> pedagio = new Queue<string>();

    static void Main(string[] args)
    {
        //entrou: van
        Enfileirar("van");
        //entrou: kombi
        Enfileirar("kombi");
        //entrou: guincho
        Enfileirar("guincho");
        //entrou: pickup
        Enfileirar("pickup");
        Desenfileirar();
    }

    private static void Desenfileirar()
    {
        if(pedagio.Any())
        {
            if(pedagio.Peek() == "guincho")
            {
                Console.WriteLine("guincho espernado");
            }
            string veiculo = pedagio.Dequeue();
            Console.WriteLine($"Saiu da fila: {veiculo}");
            ImprimirFila();

        }
    }

    private static void Enfileirar(string veiculo)
    {
        pedagio.Enqueue(veiculo);
        ImprimirFila();
    }

    private static void ImprimirFila()
    {
        Console.WriteLine("fila ");

        foreach (var item in pedagio)
        {
            Console.WriteLine(item);
        }
    }
}