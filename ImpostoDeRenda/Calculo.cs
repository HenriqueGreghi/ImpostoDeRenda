using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ImpostoDeRenda
{
    class Calculo
    {
        public double salario;
      public void CalculoImposto()
        {
           
            double imposto;
            double fimPrimeiraFaixa = 2000;
            double fimSegundaFaixa = 3000;
            double fimTerceiraFaixa = 4500;

            if (salario < fimPrimeiraFaixa)
            {
                Console.WriteLine("Isento");
            }
            else if (salario < fimSegundaFaixa)
            {
                imposto = (salario - fimPrimeiraFaixa) * 0.08;
                Console.WriteLine("R$" + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario < fimTerceiraFaixa)
            {
                imposto = (salario - fimSegundaFaixa) * 0.18 + (1000 * 0.08);
                Console.WriteLine("R$" + imposto.ToString("F2", CultureInfo.InvariantCulture));

            }
            else if (salario > fimTerceiraFaixa)
            {
                imposto = (salario - fimTerceiraFaixa) * 0.28 + (1500 * 0.18) + (1000 * 0.08);
                Console.WriteLine("R$" + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

