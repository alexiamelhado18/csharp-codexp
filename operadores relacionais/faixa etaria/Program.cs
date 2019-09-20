using System;

namespace faixa_etaria {
    class Program {
        static void Main (string[] args) {
            int idade;
            Console.WriteLine ("faixa etaria");

            //Entrada de dados

            Console.WriteLine ("Digite sua idade");
            idade = int.Parse (Console.ReadLine ());

            if (idade <= 7) {

                Console.WriteLine ("A categoria é Infantil A");

            } else if (idade <= 10) {
                Console.WriteLine ("A categoria é Infantil B");

            } else if (idade <= 13) {
                Console.WriteLine ("A categoria é Juvenil A");

            } else if (idade <= 17) {
                Console.WriteLine ("A categoria é Juvenil B");
            } else if (idade >= 18) {
                Console.WriteLine ("A categoria é Adulto");

            }
        }
    }
}