using System;
using System.Collections.Generic;

namespace Laboration_1
{
    class Program
    {
        
        static void Main(string[] args)
        {


            string number = "29535123p48723487597645723645";
            //Console.WriteLine(" Ange ett tal: ");
            //string number = Console.ReadLine();
            var standard = Console.ForegroundColor; // Sparar vit som standard färg på tecten
            long complete = 0; // er variablen värde 0
                       
            for (int i = 0; i < number.Length; i++) // Går igenom strängen från början till slut beroende på hur lång strängen är
            {
                if (char.IsDigit(number[i])) // Kollar ifall symbolen i strängen är en siffra
                {
                    for (int j = i + 1; j < number.Length; j++) // Går igenom och letar efter nästa symbol
                    {
                        if (number[i] == number[j]) // Ifall symbolen [i] är samma som [j] skriv ut allt emmelan
                        {
                            Console.Write(number.Substring(0, i)); // Används för att marker vart stringen ska börja
                            Console.ForegroundColor = ConsoleColor.Cyan; // Används för att byta färg på texten som vi vill ha
                            Console.Write(number.Substring(i, j - i + 1)); // Markerar hur lång sträng som ska byta färg, mellan symbol [i] och [j]
                            Console.ForegroundColor = (standard); // Ändrar tillbaka färgen till standarden
                            Console.Write(number.Substring(j + 1)); // Skriver ut resten av hela stringen
                            Console.WriteLine(); // Använder WriteLine för att inte få ut alla strings på samma rad
                            string alpha = number.Substring(i, j - i + 1); // Sparar den färgade stringen
                            long beta = long.Parse(alpha); // Omvandlar den sparade stringen till long
                            complete += beta; // Adderar alla färgade strängar med varandra för att få ut summan
                                                       
                            break;
                        }

                        else if (!char.IsDigit(number[j])) // Ifall den symbolen inte är en siffra så avbryt
                        {
                            break;
                        }
                    }
                }
                
                                          
            }
            Console.WriteLine("\n Den sammanlagda summan är: {0}",complete); // Får ut den kompletta summan av alla färgade stringar
            Console.Read();
        }
         

        
    

    }   
}
