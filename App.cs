namespace Recipe_App
{
    internal class App
    {
        Menu menu = new Menu();
        RecipeBook book = new RecipeBook();

        public void Run()
        {
            while (true)
            {
                menu.MainMenu();
                ConsoleKeyInfo input = Console.ReadKey(true);
                MenuCheck(input);
            }

        }

        private void MenuCheck(ConsoleKeyInfo input)
        {
            switch (input.KeyChar)
            {
                case '1':
                    menu.RecipeMenu(book.PrintRecipes());
                    var index = menu.GetIndexFromUser(book.ListLength());
                    if (index != -1)
                    {
                        Console.Clear();
                        book.PrintRecipeInfo(index);
                        menu.WaitMessage();

                    }
                    break;

                case '0':
                    menu.PrintTitleMessage("Avslutter");
                    Environment.Exit(0);
                    break;

                default:
                    menu.PrintTitleMessage("Ugyldig valg, prøv igjen");
                    menu.WaitMessage();
                    break;
            }
        }
    }
}
