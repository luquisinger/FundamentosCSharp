﻿namespace OperadoresDeConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };
            Console.WriteLine("Conectanto duas sequências");
            
            var concat = seq1.Concat(seq2);
            foreach(var seq in concat)
            {
                Console.WriteLine(seq);
            }
            Console.WriteLine();
            Console.WriteLine("União de duas sequências");
            var consulta2 = seq1.Union(seq2);
            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("União de duas sequências com comparador");
            var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Intersecção de duas sequências");
            var consulta4 = seq1.Intersect(seq2);
            foreach (var item in consulta4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Exceto: elementos da seq1 que não estão em seq2");
            var consulta5 = seq1.Except(seq2);
            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

    }
}