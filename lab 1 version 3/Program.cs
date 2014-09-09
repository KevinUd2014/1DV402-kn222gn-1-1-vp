using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_1_version_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double summa;
            int kostnad = 0;
            double utträkning;

            //slår in totalsumman i uppgiften 371,382
            Console.Write("Ange den totala summan!: ");
            summa = double.Parse(Console.ReadLine());

            //slår in bibehållen summa i uppgiften 1000
            Console.Write("Ange mottaget belopp: ");
            kostnad = int.Parse(Console.ReadLine());

            // Skriver ut "Kvitto"!
            Console.WriteLine("KVITTO");
            Console.WriteLine("-------------------------------------------------");


            Console.WriteLine("Totalt               :     {0:c}", summa);
            
            kostnad = (int)Math.Round(summa);
            utträkning = kostnad - summa;
            Console.WriteLine("Öresavrundning       :     {0:f2}", utträkning);

            Console.WriteLine("-------------------------------------------------");






        }
    }
}
