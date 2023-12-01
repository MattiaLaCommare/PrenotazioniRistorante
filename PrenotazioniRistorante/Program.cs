namespace PrenotazioniRistorante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tavoli2 = 3;
            int tavoli4 = 2;
            int tavoli6 = 5;
            int tavoliTot = tavoli2 + tavoli4 + tavoli6;
            for (int i = 0; i < tavoliTot;)
            {
            Console.WriteLine("Quanti persone");
            int persone = Convert.ToInt32(Console.ReadLine());
                if (persone <= 2)
                {
                    if (tavoli2 == 0)
                    {
                        Console.WriteLine("non ci sono più tavoli da 2");
                    }
                    else
                    {
                        Console.WriteLine("Assegnato al tavolo da 2");
                        tavoli2--;
                        tavoliTot = tavoli2 + tavoli4 + tavoli6;
                        Console.WriteLine("rimangono " + tavoliTot + " tavoli");
                    }
                }
                else if (persone > 2 && persone <= 4)
                {
                    Console.WriteLine("Assegnato al tavolo da 4");
                    tavoli4--;
                    tavoliTot = tavoli2 + tavoli4 + tavoli6;
                    Console.WriteLine("rimangono " + tavoliTot + " tavoli");
                }
                else if (persone > 4 && persone <= 6)
                {
                    Console.WriteLine("Assegnato al tavolo da 6");
                    tavoli6--;
                    tavoliTot = tavoli2 + tavoli4 + tavoli6;
                    Console.WriteLine("rimangono " + tavoliTot + " tavoli");
                }
                else if (persone > 6)
                {
                    Console.WriteLine("Troppe persone, ciao ciao");
                }
                Console.WriteLine();
            }
            Console.WriteLine("abbiamo finito i tavoli, ciaoo");
        }
    }
}