using System;
using System.Diagnostics.SymbolStore;
namespace Uppgift_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" har du gått ur gymnasiet? (j/n)"); 
           string gymnasiet = Console.ReadLine();
            
             
          

                Console.WriteLine("hur gammal är du? (svara i år)");
                int ålder = int.Parse(Console.ReadLine());

                if (gymnasiet == "j" && ålder < 22)
                {
                    Console.WriteLine(" Vi vill gärna anställa dig");
                }
                else 
                {
                    Console.WriteLine(" vi letar tyvärr efter annan personal just nu");
                }
            
        }
    }
}
