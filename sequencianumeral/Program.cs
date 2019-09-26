using System;

namespace sequencianumeral {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Imparepar");

            Console.WriteLine ("Digite o primeiro número");
            float numero1 = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite o segundo número");
            float numero2 = float.Parse (Console.ReadLine ());

            if (numero1 % 2 == 0) {

                Console.WriteLine ($"Esse número é par {numero1}");
            } else {
                Console.WriteLine ($"Esse número é impar {numero1}");
            } 
            
            if (numero2 % 2 == 0) {
                Console.WriteLine ($"Esse número é par {numero2}");
            } else {
                Console.WriteLine ($"Esse número é ímpar {numero2}");
            } 
            
             if (numero1 > numero2) {
                Console.WriteLine ($"O número 1, é maior que o número {numero1} ");
            } else{
                Console.WriteLine ($"O número 2, é menor que o número {numero2}");
            }
        }
    }
}