using System;
using System.Globalization;

namespace ImpostoDeRenda
{
    class Program
    {



        static void Main(string[] args)
        {
            Calculo calc = new Calculo();

            Console.WriteLine("Entre com o valor de seu salario:");
            calc.salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            calc.CalculoImposto();

            calc.Imprimir();
        }


    }
}
