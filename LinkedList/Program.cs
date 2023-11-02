class Program
{
    static void Main(string[] args)
    {
        List<string> frutas = new List<string>()
        {
            "abacate", "banana", "caqui", "damasco", "figo"
        };
        //vamos imprimir essa lista
        foreach (var fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
        LinkedList<string> dias = new LinkedList<string>();
        var d4 = dias.AddFirst("quarta");
        Console.WriteLine(d4.Value);
        var d2 = dias.AddBefore(d4, "segunda");
        var d3 = dias.AddAfter(d2, "terça");
        dias.Remove(d4);
        foreach(var dia  in dias)
        {
            Console.WriteLine(dia);
        }
        dias.Remove("quarta");
        foreach (var dia in dias)
        {
            Console.WriteLine(dia);
        }
    }
}