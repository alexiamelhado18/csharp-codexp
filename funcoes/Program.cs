using System;

namespace funcoes {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine (MensagemBoasVindas ());

            Console.WriteLine ("Digite o 1º numero");
            int numero1 = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite o 2º numero");
            int numero2 = int.Parse (Console.ReadLine ());

            int resultadoDaSoma = SomaDeDoisNumeros (numero1, numero2);

            Console.WriteLine ("------------------------");
            Console.WriteLine ($"O resultado da soma é {resultadoDaSoma}");
            Console.WriteLine ("------------------------");

        } //fim do main

        /// <summary>Efetua a soma de dois números</summary>
        /// <param name= "a">Primeiro valor inteiro </param>
        /// <param name= "b">Segundo valor inteiro </param>
        /// <returns>Retornar a soma dos dois números</returns>
        public static int SomaDeDoisNumeros (int a, int b) {

            int soma = a + b;

            return soma;
        }
        /// <returns>Retorna o texto de Boas Vindas</summary>
        public static string MensagemBoasVindas () {
            return "Seja bem vindo ao SENAI de Infórmatica";
        }

    }
}