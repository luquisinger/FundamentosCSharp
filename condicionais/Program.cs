class Programa
{
    static void Main(string[] args)
    {
       
        int idade = 18;
        int quantidade = 2;
        bool acompanhado = true;
        String mensagem;


        if (acompanhado == true)
        {
            mensagem = "Está acompanhado";
        }
        else
        {
            mensagem = "sozinjo";
        }

        if (idade > 16 || acompanhado == true)
        {
            Console.WriteLine("pode entrar");
            Console.WriteLine(mensagem);
        }
        else
        {

            Console.WriteLine("Não pode entrar");

        }

        Console.WriteLine();
    }
}