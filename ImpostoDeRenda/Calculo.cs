using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ImpostoDeRenda
{
    class Calculo
    {
        public decimal salario;
        public decimal imposto;
        public void CalculoImposto()
        {

            
           
            var primeiraFaixa = new[] { 0, 2000m };
            decimal[] segundaFaixa = new decimal[] { 2000.01m, 3000m };
            decimal[] terceiraFaixa = new decimal[] { 3000.01m, 4500m };

            if (salario < primeiraFaixa[1])
            {
                imposto = 0;
            }
            else if (salario < segundaFaixa[1])
            {
                imposto = (salario - primeiraFaixa[1]) * 0.08m;
               
            }
            else if (salario < terceiraFaixa[1])
            {
                imposto = (salario - segundaFaixa[1]) * 0.18m + (1000m * 0.08m);
                

            }
            else if (salario > terceiraFaixa[1])
            {
                imposto = (salario - terceiraFaixa[1]) * 0.28m + (1500m * 0.18m) + (1000m * 0.08m);
                
            }
        }
        public void Imprimir()
        {
            if(imposto == 0)
            {
                Console.WriteLine("Isento");
            }
            else if(imposto > 0)
            {
                Console.WriteLine("R$" + imposto.ToString("F2", CultureInfo.InvariantCulture));

            }
            else
            {

            }
        }
    }
}