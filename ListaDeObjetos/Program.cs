
namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            var aulaIntro = new Aula("Introdução às Coleções", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula",30);
            var aulaSets = new Aula("Trabalhando com Conjuntos", 15);
           
            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            

            aulas.Sort();
            Listar(aulas);
            
            aulas.Sort((este,outro) => este.Tempo.CompareTo(outro.Tempo));
            Listar(aulas);
        }
        class Aula : IComparable
        {
            private string titulo;
            private int tempo;

            public Aula(string titulo, int tempo)
            {
                this.titulo = titulo;
                this.tempo = tempo;
            }

            public int Tempo { get => tempo; set => tempo = value; }
            public string Titulo { get => titulo; set => titulo = value; }

            public int CompareTo(object? obj)
            {
                Aula that = obj as Aula;
                return this.titulo.CompareTo(that.titulo);
            }

            //para poder imprimir um obj na tela é preciso sobrescrever o metodo tostring
            public override string ToString()
            {
                return $"[titulo {titulo}, tempo: {tempo} minutos]";
            }
        }
        private static void Listar(List<Aula> aulas)
        {
            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
        }
    }
}