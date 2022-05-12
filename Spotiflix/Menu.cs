namespace Spotiflix
{
    public class Menu
    {
        public Menu()
        {
            //frankenstein
            MainMenu();
        }
        public void MainMenu()
        {
            //variables
            FileHandler fileHandler = new();
            SearchEngine searchEngine = new();
            int choice1, choice2;
            //startup
            fileHandler.Startup();
            //menu1
            while (true)
            {
                choice1 = FlexMenu(new() { "show list of film", "show list of music", "show list of series", "show all of the above" });
                if (choice1 == 1 || choice1 == 3)
                {
                    choice2 = FlexMenu(new() { "show all items", "search for title", "search for genre", "search for year of release" });
                }
                else if (choice1 == 2 || choice1 == 4)
                {
                    choice2 = FlexMenu(new() { "show all items", "search for title", "search for genre", "search for year of release", "search for artist" });
                }
                else
                {
                    choice2 = 0;
                }
                if (choice2 == 0)
                {
                    Environment.Exit(0);//note to self, google exit code meaning (0)
                }
                else if (choice2 == 4)
                {
                    searchEngine.SongSearch(choice2);
                }
                else
                {
                    switch (choice1)
                    {
                        case 1:
                            searchEngine.FilmSearch(choice2);
                            break;
                        case 2:
                            searchEngine.SongSearch(choice2);
                            break;
                        case 3:
                            searchEngine.SeriesSearch(choice2);
                            break;
                        case 4:
                            searchEngine.GlobalSearch(choice2);
                            break;
                    }
                }
                Console.Clear();
            }
        }
        public int FlexMenu(List<string> list)
        {
            Console.WriteLine("Menu:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"'{i + 1}' - {list[i]}");
            }
            bool looper;
            while (true)
            {
                looper = int.TryParse(Console.ReadKey().KeyChar.ToString(), out int i);
                if (looper && i <= list.Count)//maybe omit 0 / use as quit option
                {
                    Console.Clear();
                    return i;
                }
                else
                {
                    Console.Write("Invalid input, please pick a valid input from the menu" +
                        "\npress any key to return to the menu");
                    Console.ReadKey();
                }
            }
        }
    }
}