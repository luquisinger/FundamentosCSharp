namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando set de alunos
            ISet<string> alunos = new HashSet<string>();
            //adicionando: vanessa, ana, rafael
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            //imprimindo
            Console.WriteLine(string.Join(",", alunos));
            //remover ana, adicionando marcelo
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");
            //imprimindo de novo
            Console.WriteLine(string.Join(",",alunos));
            //adicionando gushiken de novo
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(",", alunos));
            List<string> lista = new List<string>(alunos);
            lista.Sort();
            Listar(lista);
        }
        private static void Listar(IList<string> aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}