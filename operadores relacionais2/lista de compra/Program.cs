using System;

namespace lista_de_compra {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Lista de compras");

            string[] produtos = new string[6];

            int contador = 0;

            while (contador <= 5) {

                Console.WriteLine ("Digite o ítem da sua compra");
                produtos[contador] = Console.ReadLine ();

                contador++;

            }

                 contador = 0;
                while (contador <= 5) {
                    Console.WriteLine ($" Seus produtos são: {produtos [contador]}");
                    contador++;
                }

        }
    }
}