using System;

namespace Exchange_Keeton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            beginProgram();
            Console.ReadLine();

        }
        public static void beginProgram()
        {
            Console.WriteLine("What is your Currency?\n");
            Console.WriteLine("1 = USD, 2 = GBP, 3 = CAD, 4 = EUR");
            ConsoleKeyInfo keyPress = Console.ReadKey(true);
            int convertFrom = getUserInput(keyPress);

            if(convertFrom > -1)
            {
                switch (convertFrom)
                {
                    case 1:
                        Console.WriteLine("United States Dollar chosen");
                        break;
                    
                    case 2:
                        Console.WriteLine("Great British Pound chosen");
                        break;

                    case 3:
                        Console.WriteLine("Canadian Dollar chosen");
                        break;

                    case 4:
                        Console.WriteLine("Euro chosen");
                        break;

                    default:
                        Console.WriteLine("You did not enter a proper response.");
                        beginProgram();
                        break;
                }
            }

            Console.WriteLine("What Currency would you like to Convert to?\n");
            Console.WriteLine("1 = USD, 2 = GBP, 3 = CAD, 4 = EUR");
            keyPress = Console.ReadKey(true);
            int convertTo = getUserInput(keyPress);

            if (convertTo > -1)
            {
                switch (convertTo)
                {
                    case 1:
                        Console.WriteLine("United States Dollar chosen");
                        break;

                    case 2:
                        Console.WriteLine("Great British Pound chosen");
                        break;

                    case 3:
                        Console.WriteLine("Canadian Dollar chosen");
                        break;

                    case 4:
                        Console.WriteLine("Euro chosen");
                        break;
                    default:
                        Console.WriteLine("You did not enter a proper number.");
                        beginProgram();
                        break;
                }
            }
            Exchanger((decimal)convertFrom, (decimal)convertTo);
        }
        private static int getUserInput(ConsoleKeyInfo keyPress)
        {
            if (keyPress.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Exiting Now");
                Environment.Exit(0);
            }
            int ret = -1;
            if (int.TryParse(keyPress.KeyChar.ToString(), out ret))
            {
                return ret;
            }
            else
            {
                return -1;
            }
        }
        public static decimal Exchanger(decimal currencyToExchangeFrom, decimal currencyToExchangeTo)
        {
            Console.WriteLine("Exchange Amount:\n");
            string amountToExchange = Console.ReadLine();
            decimal amountToConvert = 0;
            decimal.TryParse(amountToExchange, out amountToConvert);
            decimal newValue = (decimal)0.00;

            if (currencyToExchangeFrom == 1)
            {
                if (currencyToExchangeTo == 1)
                {
                    Console.WriteLine("Equal amount.");
                    beginProgram();
                }
                if (currencyToExchangeTo == 2)
                {
                    decimal usdGbp = .72523m;
                    newValue = amountToConvert * usdGbp;
                    Console.WriteLine("Your $" + amountToConvert + " USD is " + newValue.ToString("C2") + " GBP.");
                    beginProgram();
                }
                if (currencyToExchangeTo == 3)
                {
                    decimal usdCad = 1.25427m;
                    newValue = amountToConvert * usdCad;
                    Console.WriteLine("Your $" + amountToConvert + " USD is " + newValue.ToString("C2") + " CAD.");
                    beginProgram();
                }
                if (currencyToExchangeTo == 4) 
                {
                    decimal usdEur = 1.25427m;
                    newValue = amountToConvert * usdEur;
                    Console.WriteLine("Your $" + amountToConvert + " USD is " + newValue.ToString("C2") + " EUR.");
                    beginProgram();
                }
            }
            if (currencyToExchangeFrom == 2)
            {
                if (currencyToExchangeTo == 1)
                {
                    decimal gbpUsd = 1.37887m;
                    newValue = amountToConvert * gbpUsd;
                    Console.WriteLine("Your $" + amountToConvert + " GBP is " + newValue.ToString("C2") + " USD.");
                    beginProgram();
                }
                if (currencyToExchangeTo == 2)
                {
                    Console.WriteLine("Equal amount.");
                    beginProgram();
                }
                if (currencyToExchangeTo == 3)
                {
                    decimal gbpCad = 1.72947m;
                    newValue = amountToConvert * gbpCad;
                    Console.WriteLine("Your $" + amountToConvert + " GBP is " + newValue.ToString("C2") + " CAD.");
                    beginProgram();
                }
                if (currencyToExchangeTo == 4)
                {
                    decimal gbpEur = 1.15195m;
                    newValue = amountToConvert * gbpEur;
                    Console.WriteLine("Your $" + amountToConvert + " GBP i " + newValue.ToString("C2") + " EUR.");
                    beginProgram();
                }
            }
            if (currencyToExchangeFrom == 3)
            {
                if (currencyToExchangeTo == 1)
                {
                    decimal cadUsd = .79728m;
                    newValue = amountToConvert * cadUsd;
                    Console.WriteLine("Your $" + amountToConvert + " CAD is " + newValue.ToString("C2") + " USD.");
                    beginProgram();
                }
                if (currencyToExchangeTo == 2)
                {
                    decimal cadGbp = .57848m;
                    newValue = amountToConvert * cadGbp;
                    Console.WriteLine("Your $" + amountToConvert + " CAD is " + newValue.ToString("C2") + " GBP.");
                    beginProgram();
                }
                if (currencyToExchangeTo == 3)
                {
                    Console.WriteLine("Equal amount.");
                    beginProgram();
                }
                if (currencyToExchangeTo == 4)
                {
                    decimal cadEur = .66645m;
                    newValue = amountToConvert * cadEur;
                    Console.WriteLine("Your $" + amountToConvert + " CAD is " + newValue.ToString("C2") + " EUR.");
                    beginProgram();
                }
            }
            if (currencyToExchangeFrom == 4)
            {
                if (currencyToExchangeTo == 1)
                {
                    decimal eurUsd = 1.19648m;
                    newValue = amountToConvert * eurUsd;
                    Console.WriteLine("Your $" + amountToConvert + " EUR is " + newValue.ToString("C2") + " USD.");
                    beginProgram();
                }
                if (currencyToExchangeTo == 2)
                {
                    decimal eurGbp = .868226m;
                    newValue = amountToConvert * eurGbp;
                    Console.WriteLine("Your $" + amountToConvert + " EUR is " + newValue.ToString("C2") + " GBP.");
                    beginProgram();
                }
                if (currencyToExchangeTo == 3)
                {
                    decimal eurCad = 1.5004m;
                    newValue = amountToConvert * eurCad;
                    Console.WriteLine("Your $" + amountToConvert + " EUR is " + newValue.ToString("C2") + " CAD.");
                    beginProgram();
                }
                if (currencyToExchangeTo == 4)
                {
                    Console.WriteLine("Equal amount.");
                    beginProgram();
                }
            }
            return (decimal).01;
        }
    }
}
