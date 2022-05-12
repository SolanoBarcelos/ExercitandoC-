using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassos
{
    internal class Program
    {

        enum Nomes { Solano = 5, Debora = 8, Samuel };

        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar};

        static void Main(string[] args)
        {
            //gerarPreco(-33.40d, 20, "Solano"); //Função não local, abaixo da função Main

            /*
            int soma1 = Somar(10,10);
            Console.WriteLine(soma1);
            Console.ReadLine();
            */

            //Console.WriteLine("Escreva seu nome:");
            //String nome = Console.ReadLine();
            //Console.WriteLine("Seu nome é " + nome + ".");

            //int n1 = 5 / 2; //Divisão de números inteiros sempre vai retornar um numero inteiro.
            //float n2 = 6f / 2; //Divisão de um número não inteiro sempre vai retornar um número não inteiro.           

            //var nome = "Solano";
            //nome == "Atur"; //False
            //nome != "Debora"; //True

            /* Estruturas condicionais =>
             * if / else if / else =>
            String nome;
            int idade;

            Console.WriteLine("Bom dia/tarde/noite! \nDigite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Ola " + nome + "! \nDigite sua idade abaixo:");
            idade = int.Parse(Console.ReadLine());

            if(idade >= 0 && idade <= 11)
            {
                Console.WriteLine( nome + ", Você esta na infância!");
            }
            else if (idade > 11 && idade < 18)
            {
                Console.WriteLine(nome + ", Você esta na adolescência");
            }

            else if (idade > 18 && idade < 60)
            {
                Console.WriteLine(nome + ", você esta na faze adulta.");
            }

            else
            {
                Console.WriteLine(nome + ", você esta na 3ª idade.");
            }
            */

            /*
             * Switch Case =>

            string nome = "Debora";

            switch (nome)
            {
                case "Debora":
                    Console.WriteLine("Acertou");
                    break;

                case "solano":
                    Console.WriteLine("Errou");
                    break;

                default:
                    Console.WriteLine("Errou");
                    break;
            }
            */

            /*
             * Array =>
            //string[] nomes = new string[3] { "Solano", "Debora", "Barbara" };

            //Console.WriteLine(nomes[2]);
            //nomes[1] = "Marcela";
            //Console.WriteLine(nomes[1]);

            

            //int[] valores = { 1, 2, 3 };
            */

            /* Enum =>
            //enum Nomes { Solano = 5, Debora = 8, Samuel };

            Nomes nomeSolano = Nomes.Solano;
            Nomes nomeDebora = Nomes.Debora;
            Console.WriteLine((int)nomeSolano);
            Console.WriteLine(nomeSolano);
            Console.WriteLine((Nomes)8);
            
            */
            /*
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;
            Console.WriteLine(opcaoSelecionada);

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você quer criar!");
                    break;

                case Opcao.Deletar:
                    Console.WriteLine("Você quer deletar!");
                    break;

                case Opcao.Editar:
                    Console.WriteLine("Você quer editar!");
                    break;

                case Opcao.Listar:
                    Console.WriteLine("Você quer listar!");
                    break;

                case Opcao.Atualizar:
                    Console.WriteLine("Você quer atualizar!");
                    break;

                default:
                    Console.WriteLine("digite uma opção correta!");
                    break;
            }
            */

            //Estruturas de repetição =>

            //While =>
            //int contador = 0;
            //while (contador < 5)
            //{
            //    Console.WriteLine(("Rodando o While"));
            //    contador++;
            //}

            //Console.WriteLine("Fim da LINHA");

            //doWhile =>
            //do
            //{
            //    Console.WriteLine("Rodando doWhile!");
            //        contador++;
            //} while(contador<5);

            //Console.WriteLine("Fim da LINHA");


            //Foreach =>
            //string[] nomes = { "Solano", "Ed", "Caio"};

            //foreach (string nome in nomes)
            //{

            //Console.WriteLine("nome:" + nome + ".");

            //}

            ////FOR =>
            string[] nomes = { "Solano", "Ed", "Caio" };
            int numero = 1;

            for (int contador = 0; contador <= nomes.Length; contador++)
            {
                
            Console.WriteLine("Nome " + numero++ + ":" + nomes[contador] + ".");
            numero++;

            }
     
            Console.ReadLine();
        }

        //Funções =>            
        //public static double gerarPreco(Double preco, int quantidade, String nome)
        //{
        //    Double valorFinal = Math.Abs(preco * quantidade);

        //    Console.WriteLine("Olá " + nome + "!" + " O preço do produto é " + valorFinal + ".");

        //    Console.ReadLine();
        //}

        //static int Somar (int a, int b)
        //{
        //    int resultado = a + b;
        //    return resultado;
        //}


    
    }
}
