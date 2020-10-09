using System;
using System.Globalization;

using Course2.Entities;

namespace Course2
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Iniciei já com o VERSION CONTROL"

            CultureInfo culture = new CultureInfo("pt-BR");

            Comments c1 = new Comments("Tenha uma boa viagem");
            Comments c2 = new Comments("Segundo comentario");

            Posts p1 = new Posts(
                    DateTime.Parse("21/06/2018 13:05:04", culture.DateTimeFormat),
                    "Viajando para Nova Zelandia",
                    "Eu estou indo visitar esta ilha",
                    12);

            p1.AddComments(c1);
            p1.AddComments(c2);

            Comments c3 = new Comments("Comentario1");
            Comments c4 = new Comments("Comentario2");

            Posts p2 = new Posts(
                    DateTime.Parse("10/06/2020 20:05:14", culture.DateTimeFormat),
                                   "Oi..",
                                   "Tchau",
                                    7);

            p2.AddComments(c3);
            p2.AddComments(c4);


            Console.WriteLine("PRIMEIRO COMENTÁRIO");
            Console.WriteLine(p1);
            Console.WriteLine();

            Console.WriteLine("SEGUNDO COMENTÁRIO");
            Console.WriteLine(p2);


        }
    }
}