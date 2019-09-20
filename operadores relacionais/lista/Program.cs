using System;

namespace lista {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Menu");

            Console.WriteLine ("Digite o primeiro número");
            float numero1 = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite o segundo número");
            float numero2 = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite de A a F, para ver o resultado");
            Console.WriteLine ("---------------------");
            Console.WriteLine ("(A) Soma de 2 números");
            Console.WriteLine ("(B) Subtração do primeiro pelo segundo");
            Console.WriteLine ("(C) Subtração do Segundo pelo Primeiro");
            Console.WriteLine ("(D) Multiplicação dos dois números");
            Console.WriteLine ("(E) Divisão do primeiro pelo segundo");
            Console.WriteLine ("(F) Divisão do segundo pelo primeiro");
            Console.WriteLine ("---------------------");

            string resultado = Console.ReadLine ();

            switch (resultado) {
                case "a":
                    float a = numero1 + numero2;
                    Console.WriteLine ($"O resultado é {a}");
                    break;

                case "b":
                    float b = numero1 - numero2;
                    Console.WriteLine ($"O resultado é {b}");
                    break;

                case "c":
                    float c = numero2 - numero1;
                    Console.WriteLine ($"O resultado é {c}");
                    break;

                case "d":
                    float d = numero1 * numero2;
                    Console.WriteLine ($"O resultado é {d}");
                    break;

                case "e":
                    if ((numero1 > 0) && (numero2 > 0)) {
                        float e = numero1 / numero2;
                        Console.WriteLine ($"O resultado é {e}");
                    } else {
                        Console.WriteLine ("Digite um número maior que zero");
                    }
                    break;

                case "f":
                    if ((numero1 > 0) && (numero2 > 0)) {
                        float f = numero2 / numero1;
                        Console.WriteLine ($"O resultado é {f}");
                    }else {
                        Console.WriteLine ("Digite um número maior que zero");
                    }
                        break;
            }

        }
    }
}