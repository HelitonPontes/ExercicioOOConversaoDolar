using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOOConversaoDolar
{
    class Dolar
    {
        public string Nome { get; set; }
        public double Cotação { get; set; }
        public double DolarCompra { get; set; }
        public double Imposto = 6;
        public double ValorReal { get; set; }

        public Dolar()
        {

        }

        public Dolar(string nome, double cotação, double dolarCompra)
        {
            Nome = nome;
            Cotação = cotação;
            DolarCompra = dolarCompra;
        }

        public Dolar(string nome, double cotação, double dolarCompra, double valorReal) : this(nome, 
            cotação, dolarCompra)
        {
            ValorReal = valorReal;
        }

        public Dolar(string nome, double cotação, double dolarCompra, double imposto, 
            double valorReal) : this(nome, cotação, dolarCompra, imposto)
        {
            ValorReal = valorReal;
        }

        public double Resultado()
        {
            ValorReal = (DolarCompra*Cotação) /100*Imposto + (DolarCompra * Cotação);
           

            return (ValorReal);
        }



    }
}
