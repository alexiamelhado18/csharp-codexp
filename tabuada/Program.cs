using System;

namespace tabuada {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Tabuada");
            int inicial = 1;
            int multi;

            Console.WriteLine ("Digite o numero da tabuada");
            int numero = int.Parse (Console.ReadLine ());
            while (inicial <= 10) {

                multi = inicial * numero;
                Console.WriteLine ($"{inicial} x {numero} = {multi}");
                inicial = inicial + 1;

            }

        }
    }
}