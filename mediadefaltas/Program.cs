using System;

namespace mediadefaltas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media de faltas");
        //Entrada de dados 

        Console.WriteLine("Digite a 1ª nota");
        int nota1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 2ª nota");
        int nota2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade das faltas");
        int faltas =int.Parse(Console.ReadLine());


        //Processamento 


        double media = (nota1+nota2)/2;
        
        if(media>= 50 && faltas<=30){  //resultado 

Console.WriteLine("Parabéns, você foi Aprovado");
        }else{
            Console.WriteLine("Parabéns, você roi Reprovado!");
        }



        
        
        
        
        }
    }
}
