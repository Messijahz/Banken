using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Bank
{
    class Konto
    {

        double insättning;
        double saldo = 0;
        double uttag;
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Andreas bank!");
            bool avsluta = true;

            while (avsluta)
            { 
                Console.WriteLine("Ange det alternativ för vad du vill göra: ");
                Console.WriteLine("[I]nsättning");
                Console.WriteLine("[U]ttag");
                Console.WriteLine("[S]aldo");
                Console.WriteLine("[R]äntebetalning");
                Console.WriteLine("[A]vsluta");

                
                char menuAlternativ = Convert.ToChar(Console.ReadLine());
                Console.WriteLine(GetMenu(menuAlternativ));

                Console.ReadLine();
            }
        }



        static string GetMenu(char menu)
        {

            string menuChoice;
            
           

            switch (menu)
            {
                case 'I':
                    Console.WriteLine("Ange hur mycket du vill sätta in: ");
                    insättning = Convert.ToInt32(Console.ReadLine());
                    saldo = insättning + saldo;
                    menuChoice = "Du har satt in " + insättning + " Kronor.";
                    break;
                case 'U':
                    Console.WriteLine("Ange hur mycket du vill ta ut: ");
                    uttag = Convert.ToInt32(Console.ReadLine());
                    menuChoice = "Du har tagit ut " + uttag + " Kronor.";
                    break;
                case 'S':
                    menuChoice = "Ditt saldo är: " + saldo + " Kronor.";
                    break;

                case 'R':
                    double Summa = 0, ränta, sparandeÅr, totaltSparande;
                    Console.Write("Skriv in ditt årliga sparande: ");
                    totaltSparande = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ange räntan per år: ");
                    ränta = Convert.ToDouble(Console.ReadLine()) / 100;
                    Console.Write("Ange antal år du vill spara: ");
                    sparandeÅr = Convert.ToDouble(Console.ReadLine());

                    //Om antal år är mindre än antal år användaren vill spara, öka med 1 år tills användarens antal år är nådd.
                    for (int år = 1; år < sparandeÅr + 1; år++)
                    {
                        Summa = totaltSparande * Math.Pow((ränta / sparandeÅr), (sparandeÅr * år));
                        Console.Write("Ditt totala sparande efter år {0} " + " är: {1:F0}:- \n", år, Summa);
                    }
                    menuChoice = "Så här kommer din ränta att se ut.";
                    break;

                case 'A':
                    menuChoice = "Du har valt att avsluta programmet.";
                    break;
                default:
                    menuChoice = "Invalid menu character";
                    break;

            }

            return menuChoice;
        }
        
        
    }
}

/*
Console.WriteLine("Årligt sparande och ränta");
Console.WriteLine("Ange hur mycket du vill spara per år: ");
årligInsättning = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ange vilken ränta du vill ha: ");
ränta = Convert.ToDouble(Console.ReadLine());
if (ränta > 0)
{
    ränta = ränta + ränta / 100;
}
Console.WriteLine("Ange hur många år du vill spara: ");
sparandeÅr = Convert.ToDouble(Console.ReadLine());
totaltSparande = årligInsättning + ränta;
menuChoice = "Dina pengar har växt till totalt: " + totaltSparande + " kronor per år."; */