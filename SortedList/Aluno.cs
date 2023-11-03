using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    public class Aluno
    {
        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public string nome { get; set; }
        public int numeroMatricula { get; set;}
        public override string ToString()
        {
            return $"[Nome: {nome}, Matrícula: {numeroMatricula}]";
        }
        public override bool Equals(object? obj)
        {
            Aluno outro = obj as Aluno;
            if (outro == null) return false;
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }
    }

}
