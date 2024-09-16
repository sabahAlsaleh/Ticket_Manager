
namespace Ticket_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isRunning = true; // Variabel för att hålla programmet igång
            while (isRunning)
            {
                Console.WriteLine("\nVälkommen till huvudmenyn!");
                Console.WriteLine("1. Ungdom eller pensionär");
                Console.WriteLine("2. Pris för ett sällskap");
                Console.WriteLine("3. Upprepa en text tio gånger");
                Console.WriteLine("4. Det tredje ordet");
                Console.WriteLine("0. Avsluta");
                Console.Write("Välj ett alternativ: ");

                string choice = Console.ReadLine();
                switch(choice)
                {
                    
                    case "1":
                        CheckAge(); // Menyval 1: Ungdom eller pensionär
                        break;
                    case "2":
                        CalculateGroupPrice(); // Menyval 2: Pris för ett sällskap
                        break;
                    case "3":
                        RepeatText(); // Menyval 3: Upprepa text tio gånger
                        break;
                    case "4":
                        ThirdWord(); // Menyval 4: Det tredje ordet
                        break;
                    case "0":
                        isRunning = false; // Avslutar programmet
                        Console.WriteLine("Programmet avslutas.");
                        break;
                    default:
                        Console.WriteLine("Felaktigt val, försök igen.");
                         break;

                }
            }

        }

        private static void CheckAge()
        {

            Console.Write("Ange din ålder: ");
            bool IntAge= int.TryParse(Console.ReadLine(), out int age);
            if (IntAge)
            { 


            if (age < 5 || age > 100)
            {
                Console.WriteLine("Gratis inträde.");
            }

            else if (age < 20)
            {
                Console.WriteLine(" Ungdomspris: 80kr");

            }
            else if (age > 64)
            {
                Console.WriteLine(" Pensionärspris: 90kr");

            }
            else Console.WriteLine("  Standardpris: 120kr");

      

        }
            }


        private static void CalculateGroupPrice()
        {
            Console.Write("Ange hur många ni är i sällskapet: ");
            if (int.TryParse(Console.ReadLine(), out int numPeople) && numPeople > 0)
            {
                int totalCost = 0;

                for (int i = 1; i <= numPeople; i++)
                {
                    Console.Write($"Ange åldern för person {i}: ");
                    if (int.TryParse(Console.ReadLine(), out int age))
                    {
                        if (age < 5 || age > 100)
                        {
                            totalCost += 0; // Gratis
                        }
                        else if (age < 20)
                        {
                            totalCost += 80; // Ungdomspris
                        }
                        else if (age > 64)
                        {
                            totalCost += 90; // Pensionärspris
                        }
                        else
                        {
                            totalCost += 120; // Standardpris
                        }
                    }
                    else
                    {
                        Console.WriteLine("Felaktig input. Ange en giltig ålder.");
                        i--; // Minska räknaren för att fråga om åldern igen
                    }
                }

                Console.WriteLine($"Antal personer: {numPeople}");
                Console.WriteLine($"Totalkostnad för sällskapet: {totalCost}kr");
            }
            else
            {
                Console.WriteLine("Felaktig input. Ange ett giltigt antal.");
            }
        }

        private static void RepeatText()
        {
            Console.Write("Ange en text att upprepa: ");
            string input = Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}. {input} ");
            }

            Console.WriteLine(); // För en ny rad efter loopens output
        }



        private static void ThirdWord()
        {
            Console.Write("Ange en mening med minst tre ord: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');

            if (words.Length >= 3)
            {
                Console.WriteLine($"Det tredje ordet är: {words[2]}");
            }
            else
            {
                Console.WriteLine("Du angav inte minst tre ord.");
            }

        }

      
       

      

    }
}
