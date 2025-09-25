using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            nomes.Add("gustavo");
            nomes.Add("celso");

            List<Aluno> alunos = new List<Aluno>();
            Aluno suely = new Aluno { Id = 1, Nome = "Suely" };
            AlunoEspecial celso = new AlunoEspecial { Id = 2, Nome = "celso", Deficiencia = "Visual" };
            alunos.Add(suely);
            alunos.Add(celso);

            alunos.Add(new Aluno{ Id = 3, Nome = "Gustavo"} );
            nomes.Add(suely.Nome);//nome so aceita string, o nome suely é um tipo aluno, mas suely.Nome é string

            Console.WriteLine("Impressão dos nomes");
            foreach (string nome in nomes)
            {
                Console.WriteLine($" - {nome}");
            }

            Console.WriteLine("\nImpressao dos alunos\n");
            foreach (Aluno aluno in alunos)
            {
                //Console.WriteLine($" - ID {aluno.Id} - Nome {aluno.Nome}");
                aluno.ImprimirAluno();
            }
        }
    }

    class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double [] Notas { get; set; }

        public virtual void ImprimirAluno()
        {
            Console.WriteLine($"ID {this.Id} - Nome {this.Nome}");
        }
    }

    class AlunoEspecial : Aluno
    {
        public string Deficiencia { get; set; }

        public override void ImprimirAluno()
        {
            Console.WriteLine($"ID {this.Id} - Nome {this.Nome} - Deficiencia {this.Deficiencia}");
        }
    }
}

