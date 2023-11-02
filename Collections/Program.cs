
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //string[] aulas = new string[] { aulaIntro, aulaModelando, aulaSets };
            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;
            Array.Reverse(aulas);
            Imprimir(aulas);
            Array.Reverse(aulas);
            Console.WriteLine($"indice numero: "+ Array.IndexOf(aulas, aulaModelando));
            Console.WriteLine("ultimo aparecimento "+Array.LastIndexOf(aulas, aulaSets));
            Array.Sort(aulas);
            Array.Resize(ref aulas, 2);
            Imprimir(aulas);
            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);
            String[] copia = new String[2];
            Array.Copy(aulas, 1, copia, 0,2);
            String[]? clone = aulas.Clone() as string[];
            Imprimir(clone);
            Array.Clear(clone,1,2);
            Imprimir(clone);
        }

        private static void Imprimir(string[] aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}
            for(int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}