
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";
            //List<string> aulas = new List<string>()
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};
            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            aulas.RemoveAt(aulas.Count - 1);
            aulas.Add("Conclusao");

            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Listar(copia);
            List<string> clone = new List<string>(aulas);
            
            clone.RemoveRange(clone.Count - 2, 2);
            Listar(clone);
            //Listar(aulas);
            //Console.WriteLine("A primeira aula é " + aulas[0]);
            //Console.WriteLine("A primeira aula é " + aulas.First());
            //Console.WriteLine("A última aula é " + aulas[aulas.Count - 1]);
            //Console.WriteLine("A última aula é " + aulas.Last());
            //Console.WriteLine("A primeira aula com a palavra 'trabalhando'é " + aulas.First(aula => aula.Contains("Trabalhando")));
            //Console.WriteLine("A ultima aula com a palavra 'trabalhando'é " + aulas.Last(aula => aula.Contains("Trabalhando")));

        }

        private static void Listar(List<string> aulas)
        {
            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
            //for(int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}
        }
    }
}