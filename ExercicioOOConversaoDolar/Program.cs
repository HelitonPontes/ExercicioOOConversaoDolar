using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOOConversaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("XXXXXXX Programa Dolar XXXXXXXXX");
            Console.WriteLine("----------------------------------");

            Dolar Dr = new Dolar();
    

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Dolar");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------");

            Console.Write("Cadastre Nome: ");
            Dr.Nome = Console.ReadLine();
            Console.Write("Cotação: ");
            Dr.Cotação = double.Parse(Console.ReadLine());
            Console.Write("Valor em Dolar: ");
            Dr.DolarCompra= double.Parse(Console.ReadLine());
          
            Console.WriteLine("");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Nome Ciente: "+Dr.Nome+" Cotação: "+Dr.Cotação+
                " Valor de Dolar para Compra: "+ Dr.DolarCompra);


            Console.WriteLine("");
            Console.WriteLine("------------------------------------");

            Console.Write(Dr.Resultado());
            Console.WriteLine("");
            Console.WriteLine(Dr.Resultado());

            Console.WriteLine("");
            Console.WriteLine("------------------------------------");




            Console.ReadKey();
        }
    }
}
