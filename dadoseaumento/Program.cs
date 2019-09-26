using System;

namespace dadoseaumento {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Aumento salarial");

            Console.WriteLine ("Digite seu nome");
            string nome = Console.ReadLine ();
            Console.WriteLine ("Digite seu salário");
            float salario = float.Parse (Console.ReadLine ());

            Console.WriteLine ("---------------");
            Console.WriteLine ("(1) Escriturário");
            Console.WriteLine ("(2) Secretário");
            Console.WriteLine ("(3) Caixa");
            Console.WriteLine ("(4) Gerente");
            Console.WriteLine ("(5) Diretor");
            Console.WriteLine ("---------------");

            string resultado = Console.ReadLine ();

            switch (resultado) {
                case "1":
                    {
                        float acrescimo = salario * 50;
                        float aumento = acrescimo / 100;
                        float salariodoaumento = aumento + salario;
                        Console.WriteLine ($"O {nome}, ecom o aumento, seu salário é {salariodoaumento} e o seu cargo é Escriturário");
                    }
                    break;

                case "2":
                    float acrescimo = salario * 35;
                    float aumento = acrescimo / 100;
                    float salariodoaumento = aumento + salario;
                    Console.WriteLine ($"O {nome}, com o aumento, seu salário é {salariodoaumento} e o seu cargo é Secretário");
                    break;

                case "3":
                    float acrescimo = salario * 20;
                    float aumento = acrescimo / 100;
                    float salariodoaumento = aumento + salario;
                    Console.WriteLine ($"O {nome},  com o aumento, seu salário é {salariodoaumento}, e o seu cargo é Caixa");
                    break;

                case "4":
                    float acrescimo = salario * 10;
                    float aumento = acrescimo / 100;
                    float salariodoaumento = aumento + salario;
                    Console.WriteLine ($"O {nome}, ecom o aumento, seu salário é {salariodoaumento} e o seu cargo é Escriturário");
                    break;

                    case "5":
                     Console.WriteLine ($"O {nome}, e seu salario é {salariodoaumento}, sem aumento, e seu cargo é Diretor");
                    break;

                    }
            }
        }
    }