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

            Dictionary<int,string> dicNomes= new Dictionary<int, string>();
            dicNomes.Add(1,"Gustavo");
            dicNomes.Add(2, "Celso");
            dicNomes.Add(3, "Suely");

            //Nao pode adicionar chave repetida

            Console.WriteLine("\nImpressão dos dicNomes\n");
            for (int i = 1; i <= dicNomes.Count; i++)
            {
                Console.WriteLine($"ID {i} - Nome {dicNomes[i]}");
            }

            Dictionary<int, Aluno> dicAlunos = new Dictionary<int, Aluno>();

            dicAlunos.Add(suely.Id, suely);
            dicAlunos.Add(celso.Id, celso);
           

/*
            Console.WriteLine("\nImpressão dos dicAlunos\n");
            for (int i = 1; i <= dicAlunos.Count; i++)
            {
               dicAlunos[i].ImprimirAluno();
            }*/

            foreach(Aluno aluno in dicAlunos.Values)
            {

                aluno.ImprimirAluno();
            }

            Queue <string> filaNomes = new Queue<string>();
            filaNomes.Enqueue("Gustavo");
            filaNomes.Enqueue("Celso");
            filaNomes.Enqueue("Suely");

            Console.WriteLine("\nImpressão dos filaNomes\n");
            Console.WriteLine($" 1°) {filaNomes.Dequeue()}");
            foreach (string nome in filaNomes)
            {
                Console.WriteLine($" - { nome} ");
            }

            Stack<string> stackNomes = new Stack<string>();
            stackNomes.Push("Gustavo");
            stackNomes.Push("Celso");
            stackNomes.Push("Suely");

            Console.WriteLine("\nImpressão dos pilhaNomes\n");
            Console.WriteLine($" 1° sair: {stackNomes.Pop()}");

            foreach (string nome in stackNomes)
            {
                Console.WriteLine($" - {nome} ");
            }

            HashSet<string> setNomes = new HashSet<string>();
            setNomes.Add("Gustavo");
            setNomes.Add("Celso");
            setNomes.Add("Suely");
            //Ignora valores duplicados
            setNomes.Add("Gustavo");
            setNomes.Add("Celso");
            setNomes.Add("Suely");
            setNomes.Add("Suelen");

            Console.WriteLine("\nImpressão dos setNomes\n");
            foreach (string nome in setNomes)
            {
                Console.WriteLine($" - {nome} ");
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

