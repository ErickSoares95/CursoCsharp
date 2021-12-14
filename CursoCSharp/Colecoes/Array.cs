using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Erick";
            alunos[2] = "Amanda";
            alunos[3] = "Sara";
            alunos[4] = "Vivi";

            foreach (var a in alunos)
            {
                Console.WriteLine(a);
            }

            double somatorio = 0;
            double[] notas = { 7.2, 9.5, 8.3, 9.9 };
            foreach (var n in notas)
            {
                somatorio += n;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine("Media da turma é {0}",media);

        }
    }
}
