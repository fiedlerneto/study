using System;

namespace Calc
{
    public class Calculadora
    {
        // Campo
        public string Operador;

        // Propriedade
        public int Number1 { get; set; }

        public int Number2 { get; set; }

        // Construtor
        public Calculadora(string operador, int number1, int number2)
        {
            this.Operador = operador;
            Number1 = number1;
            Number2 = number2;
        }

        public Calculadora(){
            
        }

        // Método
        public int Calcular()
        {
            switch (Operador)
            {
                case "+":
                    return Number1 + Number2;
                    break;
                case "-":
                    return Number1 - Number2;
                    break;
                case "*":
                    return Number1 * Number2;
                    break;
                case "/":
                    return Number1 / Number2;
                    break;
                default:
                    return 0;
                    break;
            }

        }
    }
}