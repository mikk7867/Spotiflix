namespace Spotiflix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //variables
            FileHandler fileHandler = new();
            int choice1, choice2;
            //startup
            fileHandler.Startup();
            //menu1
            while (true)
            {
                choice1 = FlexMenu(new() { "show list of film", "show list of music", "show list of series", "show all of the above" });
                if (choice1 == 1 || choice1 == 3)
                {
                    choice2 = FlexMenu(new() { "search for title", "search for genre", "search for year of release" });
                }
                else if (choice1 == 2 || choice1 == 4)
                {
                    choice2 = FlexMenu(new() { "search for title", "search for genre", "search for year of release", "search for artist" });
                }
                else
                {
                    choice2 = 0;
                }
                switch (choice2)
                {
                    case 1:
                        switch (choice1)
                        {
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                        }
                        break;
                    case 2:
                        switch (choice1)
                        {
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                        }
                        break;
                    case 3:
                        switch (choice1)
                        {
                            case 1:

                                break;
                            case 2:

                                break;
                            case 3:

                                break;
                            case 4:

                                break;
                        }
                        break;
                    case 4:
                        //only music has artist, call music-only method
                        break;
                    default:
                        Environment.Exit(0);//note to self, google exit code meaning (0)
                        break;
                }
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