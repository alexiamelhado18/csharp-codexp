using System;

namespace Agência_de_turismo {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Agência de Turismo");

            string[] nome = new string[2];
            string[] origem = new string[2];
            string[] destino = new string[2];
            DateTime[] data = new DateTime[2];

            int opcao = 0, contador = 0;

            do {
                Console.WriteLine ("Seliciona uma opção");
                Console.WriteLine ("1 - Cadastrar Passagem");
                Console.WriteLine ("2 - Listar Passagens");
                Console.WriteLine ("0 - Sair ");
                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        string resposta = "";
                        Console.WriteLine ("Vamos cadastrar agora");

                        do {
                            if (contador < 2) {

                                Console.WriteLine ("Digite o nome do passageiro");
                                nome[contador] = Console.ReadLine ();

                                Console.WriteLine ("Digite a Origem");
                                origem[contador] = Console.ReadLine ();

                                Console.WriteLine ("Digite o Destino");
                                destino[contador] = Console.ReadLine ();

                                Console.WriteLine ("Digite a Data do Vôo");
                                data[contador] = DateTime.Parse (Console.ReadLine ());

                                Console.WriteLine ("Você deseja cadastrar mais um? S/N");
                                resposta = Console.ReadLine ();
                                contador++;
                            } else {
                                Console.WriteLine ("Número das passagens Excedidas");
                                break;
                            }
                        } while (resposta == "S");
                        break;
                        case 2:
                        Console.WriteLine ("Listando as passagens");]
                        int contadorB = 0;
                        while (contadorB < 2) 
                        {
                            Console.WriteLine ($"Passageiro nome: {nome[contadorB]}, origem: {origem[contadorB]}, Destino{destino[contadorB]}, Data do vôo {data[contadorB]}");
                            contador++;
                        }
                        break;

                        case 0:
                        Console.WriteLine ("Obrigado por usar nosso sistema");
                        break;
                        default:
                        Console.WriteLine ("Opção invalida");
                        break;
                }

            } while (opcao != 0);
        }
    }
}