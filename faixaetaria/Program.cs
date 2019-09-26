using System;

namespace faixaetaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("digite sua idade");
            int idade = int.Parse(Console.ReadLine());

             //Processamento 

if(idade<18 || idade >=60){
    Console.WriteLine("Adquiriu meia entrada");

}else{
    Console.WriteLine("Terá que pagar a intrada inteira");

}

        }
    }
}
