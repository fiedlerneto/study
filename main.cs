using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {

        int number1 = 0;
        int number2 = 0;
        int valor = 0;
        string operador;


        Console.WriteLine("Caculartor\r\n------------------------------");


        Console.WriteLine("Digite o primeiro número: ");
        number1 = int.Parse(Console.ReadLine());


        Console.WriteLine("Qual o operador vai digitar, operadores disponivels '+', '-', '*', '/': ");
        operador = Console.ReadLine();


        System.Console.WriteLine("Digite o segundo número para realizar o calculo: ");
        number2 = int.Parse(Console.ReadLine());

        switch (operador)
        {
            case "+":
                valor = number1 + number2;
                break;
            case "-":
                valor = number1 - number2;
                break;
            case "*":
                valor = number1 * number2;
                break;
            case "/":
                valor = number1 / number2;
                break;
            default:
                break;
        }

        System.Console.WriteLine("O valor da conta é: " + valor);



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
