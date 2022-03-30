using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_dias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a sua idade em anos: ");

            uint anos = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Informe sua idade em meses: ");

            uint meses = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Informe sua idade em dias: ");

            uint dias = Convert.ToUInt16(Console.ReadLine());

            uint dias_vividos = (anos * 365) + (meses * 30) + dias;

            Console.Write("O total de dias vividos é de: " + dias_vividos);

            Console.ReadKey();

        }
    }
}
