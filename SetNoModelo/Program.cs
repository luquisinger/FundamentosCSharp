
namespace SetNoModelo
{
    class Program
    {
        static void Main(string[] args)
        {
            //vamos declarar o curso
            Curso csharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");
            //... e adicionar 3 aulas a esse curso
            //Trabalhando com Listas - 21 minutos;
            //Criando uma Aula - 20 minutos;
            //Modelando com Coleções - 24 minutos
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));
            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);
            //Precisamos matricular os alunos no curso, criando um método
            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);
            //imprimindo alunos
            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }
            //imprimir: "O aluno a1 está matriculado?"
            Console.WriteLine($"O aluno a1 {a1.nome} está matriculado?");
            //O aluno a1 Vanessa Tonini está matriculado ?
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));
            Console.WriteLine(a1.Equals("Tonini"));
            Console.Clear();

            //já temos método para saber se o aluno está matriculado.
            //mas agora precisamos buscar aluno por número de matrícula

            //pergunta: "Quem é o aluno com matrícula 5617?"
            Console.WriteLine("Quem é o aluno com matrícula 5617?");
            //implementando Curso.BuscaMatriculado
            Aluno aluno5617 = csharpColecoes.BuscaMatriculado(5617);
            Console.WriteLine("aluno5617: " + aluno5617);
        }
        private static void Listar(IList<string> Alunos)
        {
            foreach (var aluno in Alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}