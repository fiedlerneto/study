using System;
using System.Globalization;
using Calc;

class Program
{
    static void Main(string[] args)
    {

        Calculadora calc = new Calculadora();

        try
        {
            Console.WriteLine("Caculartor\r\n------------------------------");


            Console.WriteLine("Digite o primeiro número: ");
            calc.Number1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Qual o operador vai digitar, operadores disponivels '+', '-', '*', '/': ");
            calc.Operador = Console.ReadLine();


            System.Console.WriteLine("Digite o segundo número para realizar o calculo: ");
            calc.Number2 = int.Parse(Console.ReadLine());

            int resultado = calc.Calcular();
            System.Console.WriteLine("O valor da conta é: " + resultado);
        }
        catch (System.Exception)
        {
            Console.WriteLine("Erro: Você digitou um valor inválido. Por favor, insira números inteiros.");

        }



        // string name = "";
        // int idade = 0;
        // bool maior = false;

        // Console.Write("Digite seu nome: ");
        // name = Console.ReadLine();

        // Console.Write("Qual a sua idade? ");
        // idade = int.Parse(Console.ReadLine());


        // if (idade >= 18)
        // {
        //     maior = true;
        // }else {
        //     maior = false;
        // }

        // switch (maior)
        // {
        //     case true:
        //         Console.WriteLine("Entrada Permitida");
        //     break;
        //     case false:
        //         Console.WriteLine("Desculpa, mas não é permitido a sua entrada");
        //     break;
        //     default:
        //         Console.WriteLine("Dados não são validos para esse método");
        //     break;
        // }

        Console.ReadLine();

    }
}
