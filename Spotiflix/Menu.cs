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
            //object(s)
            FileHandler fileHandler = new();
            SearchEngine searchEngine = new();
            //variables
            int choice1, choice2;
            //startup
            fileHandler.Startup();
            //menu1
            while (true)
            {
                //choice of category
                choice1 = FlexMenu(new() { "show list of film", "show list of music", "show list of series", "show all of the above" });
                //if chosen category doesn't include artist
                if (choice1 == 1 || choice1 == 3)
                {
                    //choice of search area
                    choice2 = FlexMenu(new() { "show all items", "search for title", "search for genre", "search for year of release" });
                }
                //if chosen category includes artist
                else if (choice1 == 2 || choice1 == 4)
                {
                    //choice of search area
                    choice2 = FlexMenu(new() { "show all items", "search for title", "search for genre", "search for year of release", "search for artist" });
                }
                //if keypress is 0 aka exit
                else
                {
                    //fix for functionallity + exiting
                    choice2 = 0;
                }
                //if exit (0) is chosen in either menu
                if (choice2 == 0)
                {
                    //clean exit => closes the console
                    Environment.Exit(0);
                }
                //if the chosen search area is artist
                else if (choice2 == 4)
                {
                    searchEngine.SongSearch(choice2);
                }
                //all other options
                else
                {
                    //switch to use correct method based on chosen category, with int for chosen search area
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
            //for each option in the list, write that option + associated number
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"'{i + 1}' - {list[i]}");
            }
            //exit option print
            Console.WriteLine("'0' - close the program");
            bool looper;
            //loop continues untill int is returned
            while (true)
            {
                looper = int.TryParse(Console.ReadKey().KeyChar.ToString(), out int i);
                //if key is digit and within list length
                if (looper && i <= list.Count)
                {
                    Console.Clear();
                    //escape from this loop + returns chosen option as associated number
                    return i;
                }
                else
                {
                    //error message
                    Console.Write("Invalid input, please pick a valid input from the menu" +
                        "\nPress any key to try again");
                    Console.ReadKey();
                }
            }
        }
    }
}