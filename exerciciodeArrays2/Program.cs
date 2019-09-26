using System;

namespace exerciciodeArrays2 {
    class Program {
        static void Main (string[] args) {
            //Objetivo efetuar o cadastro de usuário com os seguintes dadados: nome, telefone, e email de 5 usuários

            Console.WriteLine ("Exercício de Arrays 2");

            string[] nomes = new string[3];
            string[] telefones = new string[3];
            string[] emails = new string[3];

            int contador = 0;

            while (contador < 3) {

                Console.WriteLine ("Digite seu nome");
                nomes[contador] = Console.ReadLine ();

                Console.WriteLine ("Digite seu telefone");
                telefones[contador] = Console.ReadLine ();

                Console.WriteLine ("Digite seu E-mail");
                emails[contador] = Console.ReadLine ();

                contador++;
            }
            //fim do while

            int contadorB = 0;

            while (contadorB <= 3) {

                Console.WriteLine ($"O cliente número {contadorB+1} - Nomes: {nomes[contadorB]}, Tel: {telefones[contadorB]}, E-mail: {emails[contadorB]}");
                contadorB++;
            }

        }
    }

}