
namespace ListaSomenteLeitura
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharp = new Curso("C#","Matheus");
            csharp.Adiciona(new Aula("Trabalhando com listas", 21));  
            csharp.Adiciona(new Aula("Trabaljando com arrays", 20));
            csharp.Adiciona(new Aula("Criando uma Aula", 20));
            csharp.Adiciona(new Aula("Modelando com Coleções", 19));
            Listar(csharp.Aulas);

            //ordenar lista
            //csharp.Aulas.Sort();
            //copiar a lista para uma outra lista
            List<Aula> copiaAula = new List<Aula>(csharp.Aulas);
            copiaAula.Sort();
            Listar(copiaAula);
            //tempo total do curso
            Console.WriteLine(csharp.TempoTotal);
            //imprimir detalher do curso
            Console.WriteLine(csharp);

        }
        private static void Listar(IList<Aula> aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }          
        }
    }
}