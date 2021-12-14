using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploDateTime
    {
        public static void Executar() {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // Com horas
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minutes: " + diaAtual.Minute);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);
            //so o dia
            Console.WriteLine(diaAtual.ToString("dd"));
            //dia atual
            Console.WriteLine(diaAtual.ToString("d"));
            //descritivo 
            Console.WriteLine(diaAtual.ToString("D"));
            //dai e hora
            Console.WriteLine(diaAtual.ToString("g"));
            //dia e hora com segundos
            Console.WriteLine(diaAtual.ToString("G"));
            //formatar
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}
