using System;

namespace resultado_da_media {
    class Program {
        static void Main (string[] args) {
            // aqui é onde iremos inserir o código 
            Console.WriteLine ("Soma de três notas");

            int n1;
            int n2;
            int n3;

            Console.WriteLine ("Digite a primeira nota");
            n1 = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite a segunda nota");
            n2 = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite a terceira nota");
            n3 = int.Parse (Console.ReadLine ());

            float soma = (n1 + n2 + n3);
            float resultado = soma / 3;
            Console.WriteLine ($"O Resultado é: {resultado}");

        }
    }
}