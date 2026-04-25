using System;

namespace benzinaProject
{
    class Program
    {
        static void Main()
        {
          Console.WriteLine("Cati bani ai pentru benzina ? ");
          double bani = Convert.ToDouble( Console.ReadLine());

          Console.WriteLine("Cati bani costa 1 litru ? ");
          double costul = Convert.ToDouble (Console.ReadLine ());

          double totalLitri = bani / costul ;

          //double rotunjire = Math.Round (totalLitri , 2);
          double rotunjire = Math.Floor (totalLitri );
          //double rotunjire = Math.Ceiling (totalLitri );

          Console.WriteLine(" Tu vei primi " + rotunjire + " litri pentru " + bani + " lei ");
        }
    }
}