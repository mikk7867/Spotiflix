//outcommented, intended functionallity added to program.cs
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spotiflix;

namespace Spotiflix
{
    internal class Menu
    {
        //Specified search menu.
        public List<string> SpecMenu(char input)
        {
            FileHandler fileHandler = new();
            List<List<string>> list = new();
            string result;
            bool check;
            do
            {
                check = true;
                Console.Clear();
                Console.WriteLine("Choose a specified search below" +
                 "\n\nFilm   - '1'" +
                 "\nSeries - '2'" +
                 "\nMusic  - '3'" +
                 "\nOther  - '4'");
                input = Console.ReadKey().KeyChar;

                switch (input)
                {
                    case '1':
                        //hent liste af film
                        List<Film> film = fileHandler.GetFilm();
                        //lav string af udprint
                        foreach (Film f in film)
                        {
                            list.Add($"Title: {f.Title}\n" +
                                $"Playtime: {f.Time.Unit1}t {f.Time.Unit2}m\n" +
                                $"Genre: {f.Genre}\n" +
                                $"Release date: {f.Date}\n" +
                                $"URL: {f.Url}\n");
                            //string list .add f
                        }
                        //return obj film.
                        return list;
                    case '2':
                        //return obj serier.
                        break;
                    case '3':
                        //return obj musik.
                        break;
                    case '4':
                        //Kald OtherMenu
                        return result = Menu.OtherMenu(input);
                        break;
                    default:
                        Console.Write("Invalid input, please pick a valid input from the menu" +
                            "\npress any key to return to the menu");
                        Console.ReadKey();
                        check = false;
                        break;
                } 
            } while (!check);
        }
        //Other specsearch menu.
        public char OtherMenu(char input)
        {
            bool check;
            string result.

            do
            {
                Console.Clear();
                Console.WriteLine("Choose the searchtype below" +
                 "\n\nTitel        - '1'" +
                 "\nGenre        - '2'" +
                 "\nPlaytime     - '3'" +
                 "\nRelease date - '4'" +
                 "\nwww          - '5'");
                input = Console.ReadKey().KeyChar;

                if (input == '1' || input == '2' || input == '3' || input == '4' || input == '5')
                {
                    check = true;
                    //Kald SpecSearch.
                    return result = Menu.SpecSearch(input);
                }
                else
                {
                    Console.Write("Invalid input, please pick a valid input from the menu" +
                        "\npress any key to return to the menu");
                    Console.ReadKey();
                    check = false;
                }
            } while (!check);
        }

        //Specified search function.
        public string SpecSearch(char input)
        {
            string search;
            bool check;

            do
            {
                Console.Clear();
                check = true;
                switch (input)
                {
                    case '1'://Titel
                        Console.Write("Titel: ");
                        Console.ReadLine();
                        return;
                        //return hentede filer relatered til søgning.
                        break;
                    case '2'://Genre
                        Console.Write("Genre: ");
                        Console.ReadLine();
                        return;
                        //return hentede filer relatered til søgning.
                        break;
                    case '3'://Playtime
                        Console.Write("Playtime: ");
                        Console.ReadLine();
                        return;
                        //return hentede filer relatered til søgning.
                        break;
                    case '4': //Release date
                        Console.Write("Release date: ");
                        Console.ReadLine();
                        return;
                        //return hentede filer relatered til søgning.
                        break;
                    case '5': //www (URL)
                        Console.Write("URL: ");
                        Console.ReadLine();
                        return;
                        //return hentede filer relatered til søgning.
                        break;
                    default:
                        Console.Write("Invalid input, please pick a valid input from the menu" +
                            "\npress any key to return to the menu");
                        Console.ReadKey();
                        check = false;
                        break;
                }
            } while (!check);
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
            }
        }
    }
}
*/