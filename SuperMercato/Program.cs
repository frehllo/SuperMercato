using System;

namespace SuperMercato
{
    class Program
    {
        static void Main(string[] args)
        {            
            double prezzofinale = 0;
            double sconto;
            double tot = 0;
            Console.Write("Quanto ha speso? ");
            tot = int.Parse(Console.ReadLine());
            if(tot > 100)
            {
                sconto = (tot / 100) * 20;
                prezzofinale = tot - sconto;
                Console.WriteLine($"Hai speso più di 100 euro, applicando uno sconto paghi {prezzofinale} euro ");
                Console.ReadLine();
            }else
            {
                Console.WriteLine("Niente sconto, arrivederci e grazie :)");
                Console.ReadLine();
            }
        }
    }
}
