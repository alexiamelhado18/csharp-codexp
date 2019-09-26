using System;

namespace media_escolar {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("App de Média escolar");
            //Entrada de dados 

            Console.WriteLine ("Digite seu nome");
            string nome = Console.ReadLine ();

            Console.WriteLine ("Digite a primeira nota:"); //Recebe um texto
            string valorDigitado = Console.ReadLine ();
            float nota1 = float.Parse (valorDigitado); //Converte o texto em número(float)

            Console.WriteLine ("Digite a segunda nota:");
            float nota2 = float.Parse (Console.ReadLine ()); //Recebe o valor digitado e converte

            //Processamento 
            float media = (nota1 + nota2) / 2;
            string resultado; // string sem valor
            if (media >= 7) {
                resultado = "Aprovado"; //Atribui valor
            }else{
                resultado = "Reprovado";
            }
Console.WriteLine($"O aluno {nome} com a média {media} está {resultado}");
        }
    }
}