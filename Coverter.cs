﻿namespace ParprogrammeringUke2
{
    static class Converter
    {
        public static void Run()
        {
            string[] validInputs = { "1", "2", "3", "4", "5", "6" };
            string[] currencyLabels = { "USD", "NOK", "EUR", "CAD", "JPY", "SEK" };
            string currencies = @"
1. USD       4. CAD
2. NOK       5. JPY
3. EUR       6. SEK";
            Console.WriteLine("Dette er en valuta konverteringsprogram!");
            Console.WriteLine("Velg hvilken valuta du vil konvertere fra: ");
            Console.WriteLine(currencies);

            string currencyFrom = "";

            while (!validInputs.Contains(currencyFrom))
            {
                currencyFrom = Console.ReadLine();
                if (!validInputs.Contains(currencyFrom)) Console.WriteLine("Ugyldig input!");
            }

            Console.Write("Verdi: ");
            string fromValueString = Console.ReadLine();
            double fromValueNumber = double.Parse(fromValueString);
            switch (currencyFrom)
            {
                case "1":
                    fromValueNumber /= NOKtoOthers.USD;
                    break;
                case "2":
                    break;
                case "3":
                    fromValueNumber /= NOKtoOthers.EUR;
                    break;
                case "4":
                    fromValueNumber /= NOKtoOthers.CAD;
                    break;
                case "5":
                    fromValueNumber /= NOKtoOthers.JPY;
                    break;
                case "6":
                    fromValueNumber /= NOKtoOthers.SEK;
                    break;
            }
            
            string currencyTo = "";
            double convertedCurrency = 0;
            while (!validInputs.Contains(currencyTo))
            {
                Console.WriteLine("Velg valuta du vil konvertere til: ");
                Console.WriteLine(currencies);
                currencyTo = Console.ReadLine();
                switch (currencyTo)
                {
                    case "1":
                        convertedCurrency = fromValueNumber * NOKtoOthers.USD;
                        break;
                    case "2":
                        convertedCurrency = fromValueNumber;
                        break;
                    case "3":
                        convertedCurrency = fromValueNumber * NOKtoOthers.EUR;
                        break;
                    case "4":
                        convertedCurrency = fromValueNumber * NOKtoOthers.CAD;
                        break;
                    case "5":
                        convertedCurrency = fromValueNumber * NOKtoOthers.JPY;
                        break;
                    case "6":
                        convertedCurrency = fromValueNumber * NOKtoOthers.SEK;
                        break;
                    default:
                        Console.WriteLine("Ugyldig input!");
                        break;
                }
            }
            string roundedCurrency = convertedCurrency.ToString("N2");
            Console.WriteLine($"{fromValueString} {currencyLabels[int.Parse(currencyFrom)-1]} = {roundedCurrency} {currencyLabels[int.Parse(currencyTo) - 1]}");
        }
    }
    static class NOKtoOthers
    {
        public static double USD = 0.0936213;
        public static double NOK = 1;
        public static double EUR = 0.0856732;
        public static double CAD = 0.128411;
        public static double JPY = 13.90440;
        public static double SEK = 0.976703;
    }
}

/*
 * USD -> JPY 5.0$
 * USD / NOKtoOthers.USD * NOKtoOthers.JPY
 */