namespace Recipe_App
{
    internal class MenuConsole
    {
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("\n--- OPPSKRIFT APP ---\n");
            Console.WriteLine("1 - Se alle oppskrifter\n0 - Avslutt");
        }

        public static void RecipeMenu(string recipies)
        {
            Console.Clear();
            Console.WriteLine(recipies);
            Console.WriteLine("\nSkriv inn tallet på oppskriften du ønsker å se på\nENTER - Gå tilbake");
        }

        public static int GetIndexFromUser(int maxIndex)
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (number < maxIndex && number >= 0)
                {
                    return number;
                }
            }
            return -1;
        }

        public static void WaitMessage()
        {
            Console.WriteLine("\n<- Gå tilbake");
            Console.ReadKey();
        }
        public static void PrintTitleMessage(string message)
        {
            Console.WriteLine($"\n--- {message} ---\n");
        }


    }
}
