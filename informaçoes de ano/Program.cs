using System;

namespace informaçoes_de_ano {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Informaçoes do ano");
            int nascimento;
            int anoatual;

            Console.WriteLine ("Digite sua data de nascimento");
            nascimento = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Digite o ano atual");
            anoatual = int.Parse (Console.ReadLine ());

            int idade = anoatual-nascimento;
            int semana = idade*4*12;

Console.WriteLine($"Sua idade é {idade}, e sua idade convertida em semana {semana}");

        }
    }
}