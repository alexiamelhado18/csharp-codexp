using System;

namespace controle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("controle");
             int salarioFixo;
             int totaldeVendas;
            

             Console.WriteLine("Digite seu salario");
salarioFixo = int.Parse (Console.ReadLine ());

Console.WriteLine("Digite total de vendas");
totaldeVendas = int.Parse (Console.ReadLine ());

// Console.WriteLine("Digite sua comissão");
// int comissão = int.Parse (Console.ReadLine ());
 
 int contadaComissao = totaldeVendas*5;
 int comissaodeVendas = contadaComissao/100;
 int totalaReceber = comissaodeVendas+salarioFixo;
//  int totalaReceber = salarioFixo + (comissaodeVendas/100*salarioFixo);
 
 Console.WriteLine($"Seu salario fixo é {salarioFixo}; Total de vendas é {totaldeVendas}, e a TOTAL a receber é {totalaReceber}");


        }
    }
}
