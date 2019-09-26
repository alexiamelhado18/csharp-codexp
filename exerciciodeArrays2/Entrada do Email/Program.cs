using System;

namespace Entrada_do_Email {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Entrada do Email");

            string emails;
            


           do{

                Console.WriteLine ("Digite seu email");
                emails = Console.ReadLine ();

            } while(!emails.Contains("@") ||  !emails.Contains(".")); 

        string senha;

        do{
            Console.WriteLine("Digite a senha");
            senha = Console.ReadLine();
        } while(senha.Length <=6);

        }
    }
}