using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA_PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("====== MENU ======");
            Console.WriteLine(" 1 exercicio ");
            Console.WriteLine(" 2 exercico ");
            Console.WriteLine(" 3 exercicio ");
            Console.WriteLine(" 4 exercico ");
            Console.WriteLine(" 5 exercicio ");
            Console.WriteLine(" 6 exercicio ");
            Console.WriteLine(" 7 exercicio ");
            Console.WriteLine("============");

            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:

                    int number;

                    Console.WriteLine("digite um numero: ");
                    number = int.Parse(Console.ReadLine()); 

                    if(num < 0)
                    {
                        number = -number;
                    }

                    Console.WriteLine("O resultado absoluto é " + number);
                    Console.ReadKey();
                    break;



                case 2:

                    int numere;

                    Console.WriteLine("digite um numero: ");
                    numere = int.Parse(Console.ReadLine());

                    
                        if (numere * 3 == 0 && numere * 5 == 0)
                        {
                            Console.WriteLine("É multiplo por 3 e 5! ");
                        }

                        else if (numere * 4 == 0 && numere * 7 == 0)
                        {
                            Console.WriteLine("É multiplo por 4 e 7! ");
                        }

                        else if (numere % 3 == 0)
                        {
                            Console.WriteLine("É divisivel somente por 3!");

                        }

                        else if (numere % 5 == 0)
                        {
                            Console.WriteLine("É divisivel somente por 5!");
                        }

                        else if (numere % 4 == 0)
                        {
                            Console.WriteLine("É divisivel somente por 4!");
                        }

                        else if (numere % 7 == 0)
                        {
                            Console.WriteLine("É divisivel somente por  7!");

                        }

                        else
                            Console.WriteLine("O numero informado nao tem posssibilidade de divisão ");
                            Console.ReadKey();
                        break;

             

                    case 3:

                    int NUMERO1, NUMERO2, NUMERO3;

                    Console.WriteLine("Digite numero 1: ");
                    NUMERO1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite numero 2: ");
                    NUMERO2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite numero 3: ");
                    NUMERO3 = int.Parse(Console.ReadLine());

                    

                    break;



                    case 4:

                    int N;

                    Console.WriteLine("======== MENU ========");
                    Console.WriteLine("1");
                    Console.WriteLine("2");
                    Console.WriteLine("3");
                    Console.WriteLine("4");
                    Console.WriteLine("5");
                    Console.WriteLine("6");
                    Console.WriteLine("7");
                    Console.WriteLine("======================");

                    Console.WriteLine("Escolha um numero de 1 à 7: ");
                    N = int.Parse(Console.ReadLine());

                    switch (N)
                    {
                        case 1:
                            Console.WriteLine(" Domingo - Assisto TV ");
                            break;
                        case 2:
                            Console.WriteLine(" Segunda - Filosofia, Portugues, Matematica. ");
                            break;
                        case 3:
                            Console.WriteLine(" Terça - Quimica, Historia, Ingles. ");
                            break;
                        case 4:
                            Console.WriteLine(" Quarta - Biologia, Portugues, Programação. ");
                            break;
                        case 5:
                            Console.WriteLine(" Quinta - Fisica, Rede de Computadores, sociologia. ");
                            break;
                        case 6:
                            Console.WriteLine(" Sexta - Geografia, Matematica, Banco de Dados. ");
                            break;
                        case 7:
                            Console.WriteLine(" Sabado - Saio com os amigos ");
                            break;

                        default:
                            Console.WriteLine("Opção Invalida");
                            break;
                    }
                    break;

                     case 5:

                    int NUM, menor, maior, parada = 1;

                    Console.WriteLine("digite um numero: ");
                    NUM = int.Parse(Console.ReadLine());

                    menor = NUM;
                    maior = NUM;

                    for (int i = 0; parada != 0; i++)
                    {
                        Console.WriteLine("digite um numero: ");
                        NUM = int.Parse(Console.ReadLine());

                         if (NUM < menor)
                        {
                            menor = NUM;
                        }
                               
                        if (NUM > maior)
                        {
                            maior = NUM;
                        }

                        Console.WriteLine("Digite 1 para continuar ou 0 para parar. ");
                        parada = int.Parse(Console.ReadLine());

                    }
                    
                    Console.WriteLine("o maior numero = {1} ", maior);
                    Console.WriteLine("o menor numero = {0} ", menor);

                    break;

                    case 6:

                    int nm, soma = 0;

                    Console.WriteLine("Digite um numero: ");
                    nm = int.Parse(Console.ReadLine());
                    
                    for (int i = 1; 1 < nm; i++)
                    {
                        if(nm % i == 0)
                        {
                            soma += i;
                        }
                    }

                    if (soma == nm)
                    {
                        Console.WriteLine("É um numero perfeito! " + nm);
                    }
                    else
                    {
                        Console.WriteLine("Não é um numero perfeito! " + nm);
                    }

                    break;

                    


            }

            Console.ReadKey();
        }

    }
}
