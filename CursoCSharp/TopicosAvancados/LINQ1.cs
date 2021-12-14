using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{//LANGUAGE INTEGRATED QUERY
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    class LINQ1
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno(){Nome =" Pedro", Idade =24, Nota=8.0},
                new Aluno(){Nome =" Erick", Idade =26, Nota=9.1},
                new Aluno(){Nome =" Erica", Idade =30, Nota=9.5},
                new Aluno(){Nome =" Ewerton", Idade =26, Nota=10.0},
                new Aluno(){Nome =" Ewerton", Idade =27, Nota=6.7},
                new Aluno(){Nome =" Jose", Idade =40, Nota=8.5},
                new Aluno(){Nome =" Claudio", Idade =35, Nota=6.8}
            };

            Console.WriteLine(" == Aprovados ============");
            Console.WriteLine(" == Aprovados ============");
            var aprovados = alunos.Where(a => a.Nota >= 7)
                .OrderBy(a => a.Nome);
            foreach(var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }
            //select ele transforma uma lista em outra lista de string
            Console.WriteLine("\n == Chamada ============");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach(var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n == Chamada ============");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach(var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
