using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSomenteLeitura
{
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
}
