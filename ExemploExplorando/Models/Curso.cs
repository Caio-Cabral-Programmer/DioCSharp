using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
            Console.WriteLine($"Aluno {aluno.NomeCompleto} adicionado ao curso {Nome}.");
        }

        public int ObterTotalAlunosMatriculados()
        {
            int total = Alunos.Count;
            return total;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            if (Alunos.Remove(aluno))
            {
                Console.WriteLine($"Aluno {aluno.NomeCompleto} removido do curso {Nome}.");
            }
            else
            {
                Console.WriteLine($"Aluno {aluno.NomeCompleto} não encontrado no curso {Nome}.");
            }

            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos matriculados no curso {Nome}:");
            int contador = 1;
            foreach (var aluno in Alunos)
            {
                Console.WriteLine($" {contador}. {aluno.NomeCompleto}, Idade: {aluno.Idade}");
                contador++;
            }
        }
    }
}