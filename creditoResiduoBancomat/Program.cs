using System;

namespace creditoResiduoBancomat
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldodisp, spese, costo, spfatte = 0;

            Console.WriteLine("inserire il saldo disponibile");
            saldodisp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("inserire il numero di spese");
            spese = Convert.ToDouble(Console.ReadLine());
            while (spfatte < spese)
            {
                Console.Write("inserisci l'importo della spesa: ");
                costo = double.Parse(Console.ReadLine());
                if (costo > saldodisp)
                {
                    Console.WriteLine("soldi insufficenti");

                }
                else
                {
                    saldodisp = saldodisp - costo;
                    Console.WriteLine($"dopo la tua spesa ti rimarranno:{saldodisp}");
                }
                spfatte++;
            }
            Console.WriteLine($"Hai eseguito {spfatte} acquisti, saldo rimanente:{saldodisp}"); 
            Console.ReadLine();
        }
    }
}
