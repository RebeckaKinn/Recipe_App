namespace Recipe_App
{
    internal class Recipe
    {
        public string Title { get; private set; }
        public string DishType { get; private set; }
        private string _description;
        private int _estimatedTimeInMinutes;
        private int _servings;
        private List<string> _ingredients;
        private List<string> _instructions;

        public Recipe(string title, string dishType, string description, int time, int servings, List<string> ingredients, List<string> instructions)
        {
            Title = title;
            DishType = dishType;
            _description = description;
            _estimatedTimeInMinutes = time;
            _servings = servings;
            _ingredients = ingredients;
            _instructions = instructions;
        }

        public void PrintRecipeInfo()
        {
            Console.WriteLine($"\n--- {Title} ---");
            Console.WriteLine($"Type: {DishType}\nTid: {GetTime()} | Servering: {_servings}");
            Console.WriteLine($"{_description}");
            Console.WriteLine($"\nIdgredienser:\n{PrintIngredients()}");
            Console.WriteLine(PrintInstructions());
        }

        private string PrintIngredients()
        {
            string items = "";
            foreach (string item in _ingredients)
            {
                items += $"- {item}\n";
            }
            return items;
        }
        private string PrintInstructions()
        {
            string items = "";
            foreach (string item in _instructions)
            {
                items += $"{item}\n";
            }
            return items;
        }


        private string GetTime()
        {
            return $"{_estimatedTimeInMinutes} min.";
        }
    }
}
