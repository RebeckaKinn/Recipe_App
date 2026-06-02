namespace Recipe_App
{
    internal class RecipeBook
    {
        private List<Recipe> _recipes;

        public RecipeBook()
        {
            _recipes = GetInitialRecipes();


        }

        public string GetRecipeNames()
        {
            string items = "";
            for (int i = 0; i < _recipes.Count; i++)
            {
                items += $"{i} - {_recipes[i].Title}\n";
            }
            return items;
        }

        public int ListLength()
        {
            return _recipes.Count;
        }

        public void PrintRecipeInfo(int index)
        {
            _recipes[index].PrintRecipeInfo();
        }
        private static List<Recipe> GetInitialRecipes()
        {
            return new List<Recipe>
            {
                 new Recipe(
                "Spaghetti Bolognese",
                "Middag",
                "En klassisk italiensk pastarett med kjøttsaus.",
                45,
                4,
                new List<string>
                {
                    "400 g kjøttdeig",
                    "1 løk",
                    "2 fedd hvitløk",
                    "400 g hakkede tomater",
                    "300 g spaghetti"
                },
                new List<string>
                {
                    "Stek kjøttdeigen.",
                    "Tilsett hakket løk og hvitløk.",
                    "Ha i tomatene og la sausen småkoke i 30 minutter.",
                    "Kok spaghettien etter anvisningen på pakken.",
                    "Server sausen over spaghettien."
                }
            ),

            new Recipe(
                "Pannekaker",
                "Dessert",
                "Luftige og gode pannekaker.",
                20,
                4,
                new List<string>
                {
                    "3 egg",
                    "5 dl melk",
                    "250 g hvetemel",
                    "1 ss sukker",
                    "1 klype salt"
                },
                new List<string>
                {
                    "Visp sammen egg og melk.",
                    "Tilsett mel, sukker og salt.",
                    "La røren hvile i 10 minutter.",
                    "Stek pannekakene gyllenbrune på begge sider."
                }
            ),

            new Recipe(
                "Kyllingsalat",
                "Lunsj",
                "En frisk salat med grillet kylling.",
                25,
                2,
                new List<string>
                {
                    "2 kyllingfileter",
                    "1 hjertesalat",
                    "10 cherrytomater",
                    "1 agurk",
                    "2 ss olivenolje"
                },
                new List<string>
                {
                    "Stek eller grill kyllingfiletene.",
                    "Kutt grønnsakene i passende biter.",
                    "Skjær kyllingen i strimler.",
                    "Bland alt sammen og server."
                }
            ),

            new Recipe(
                "Tomatsuppe",
                "Forrett",
                "En enkel og smakfull tomatsuppe.",
                30,
                4,
                new List<string>
                {
                    "800 g hermetiske tomater",
                    "1 løk",
                    "2 fedd hvitløk",
                    "5 dl grønnsakskraft",
                    "1 ss olivenolje"
                },
                new List<string>
                {
                    "Stek løk og hvitløk i olje.",
                    "Tilsett tomater og kraft.",
                    "La suppen koke i 20 minutter.",
                    "Kjør suppen glatt med stavmikser.",
                    "Server varm."
                }
            ),

            new Recipe(
                "Sjokoladekake",
                "Bakverk",
                "Saftig sjokoladekake som passer til enhver anledning.",
                60,
                8,
                new List<string>
                {
                    "200 g smør",
                    "4 egg",
                    "250 g sukker",
                    "200 g hvetemel",
                    "50 g kakao"
                },
                new List<string>
                {
                    "Smelt smøret.",
                    "Visp egg og sukker luftig.",
                    "Bland inn resten av ingrediensene.",
                    "Hell røren i en form.",
                    "Stek på 175°C i ca. 35 minutter."
                }
            )
            };
        }

    }

}
