using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start_functies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Velden 
            String _voornaam = null, _achternaam = null, _mailadres = null;

            //GUI
            //Vraag de gegevens aan de gebruiker
            Console.Write("Geef uw voornaam: ");
            _voornaam = Console.ReadLine();
            Console.Write("Geef uw achternaam: ");
            _achternaam = Console.ReadLine();

            // Vraag mailadres op
            _mailadres = MakenMailadres(_achternaam,_voornaam);

            // toon mail adres
            Console.Clear();

            Console.WriteLine($"Uw mailadres: {_mailadres}");

            Console.ReadKey();
        }

        // Functies
        static String MakenMailadres(String ontvAchternaam, String ontvVoornaam)
        {
            String antwoord = null;

            antwoord = $"{ontvAchternaam}.{ontvVoornaam}@romerocollege.be";

            return antwoord;
        }
    }
}
