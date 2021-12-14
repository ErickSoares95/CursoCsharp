using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar() {
            double valor = 15.175;
            //unica casa decima
            Console.WriteLine(valor.ToString("F1"));
            //valor monetário
            Console.WriteLine(valor.ToString("C"));
            //Percentual
            Console.WriteLine(valor.ToString("P"));
            //numero duas casas decimais
            Console.WriteLine(valor.ToString("#.##"));
            //pais para ser trazido informações de cultura
            CultureInfo cultura = new CultureInfo("en-US");
            //c0 em dinheiro com nhma casa decimal
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            //10 caracteres completando com 0 a esquerda
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
