using System;

namespace calculo_da_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculo da idade");
        int idade;

            Console.WriteLine("Digite a idade");
            idade = int.Parse (Console.ReadLine ());

int meses = idade*12;
int dias = idade*365;
int horas = dias*24;
int minutos = horas*60;

Console.WriteLine ($"Em {idade} anos, você viveu {meses} meses, {dias} dias, {horas} horas, {minutos} minutos");
        


        }
    }
}
