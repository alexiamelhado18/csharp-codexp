using System;

namespace rodiziodecarro {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Rodízio de carro");
            // Entrada de dados

            Console.WriteLine ("Digite sua placa");
            int placa = int.Parse (Console.ReadLine ());

// Console.WriteLine("Digite o dia do rodízio");
// int rodizio = int.Parse(Console.ReadLine());

if(placa == 0 || placa == 1){
    Console.WriteLine("O dia do seu rodízio é na Segunda-feira");
}else if(placa == 2 || placa == 3){
    Console.WriteLine("O dia do seu rodízo é na Terça-feira");
}else if(placa == 4 || placa == 5){
    Console.WriteLine("O dia do seu rodízio é Quarta-feira");
}else if(placa ==6 || placa == 7){
    Console.WriteLine("O dia do seu rodizío é Quinta-feira");
}else {
    Console.WriteLine("O dia don seu rodízio é Sexta-feira");

}

        }
    }
}