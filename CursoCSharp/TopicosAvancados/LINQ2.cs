using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
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

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno inexistente!");
            }

            var ewerton = alunos.First(aluno => aluno.Nome.Equals("Ewerton"));
            Console.WriteLine(ewerton.Nota);
            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Ewerton2"));
            if(sicrano == null)
            {
                Console.WriteLine("Aluno inexistente!");
            }
            var outroEwerton = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ewerton"));
            Console.WriteLine(outroEwerton.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach(var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var soma = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(soma);

            var media = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(media);
        }
    }
}
