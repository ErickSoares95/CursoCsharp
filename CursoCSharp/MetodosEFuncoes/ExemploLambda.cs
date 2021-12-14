using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            // Action é um função que nao tem retorno, a função esta sendo armazenada na variavels algoNoConsole.
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());
            //int é parametro e o string é o retorno
            //numero é parametro
            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            //parenteses de numero não obrigatório no caso de só um parametro
            //Func<int, string> conversorHex = (numero) =>
            //{
            //    return numero.ToString("X");
            //};

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(17, 05, 1995));
        }
        
    }
}
