using System;

namespace identidade {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Identidade");

            int[] idade = new int[10];

            int contador = 0;

            while (contador <= 9) {

                Console.WriteLine ("Digite sua idade");
                idade[contador] = int.Parse (Console.ReadLine ());

                if (idade[contador] < 18) {
                    Console.WriteLine ($"--Menor de idade--");
                } else {
                    Console.WriteLine ($"--Maior de idade--");
                }
                contador++;


            }

        }
    }
}
