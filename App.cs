namespace Recipe_App
{
    internal class App
    {
        private RecipeBook _book = new RecipeBook();

        public void Run()
        {
            while (true)
            {
                MenuConsole.MainMenu();
                ConsoleKeyInfo input = Console.ReadKey(true);
                MenuCheck(input);
            }

        }

        private void MenuCheck(ConsoleKeyInfo input)
        {
            switch (input.KeyChar)
            {
                case '1':
                    MenuConsole.RecipeMenu(_book.GetRecipeNames());
                    var index = MenuConsole.GetIndexFromUser(_book.ListLength());
                    if (index != -1)
                    {
                        Console.Clear();
                        _book.PrintRecipeInfo(index);
                        MenuConsole.WaitMessage();

                    }
                    break;

                case '0':
                    MenuConsole.PrintTitleMessage("Avslutter");
                    Environment.Exit(0);
                    break;

                default:
                    MenuConsole.PrintTitleMessage("Ugyldig valg, prøv igjen");
                    MenuConsole.WaitMessage();
                    break;
            }
        }
    }
}
