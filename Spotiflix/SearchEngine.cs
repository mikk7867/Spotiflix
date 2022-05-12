using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//methods used for searching/limiting search

namespace Spotiflix
{
    internal class SearchEngine
    {
        FileHandler fileHandler = new();
        public void FilmSearch(int choice)
        {
            //get list of all films in database
            List<Film> list = fileHandler.GetFilm(), 
                print = new();
            //input variables
            string in1;
            int in2;
            //switch based on what the user wants to search for
            switch (choice)
            {
                case 1:
                    print = list;
                    break;
                case 2://title
                    //input method
                    in1 = StringInput();
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach(Film film in list)
                    {
                        if(film.Title.ToLower().Contains(in1))
                        {
                            print.Add(film);
                        }
                    }
                    break;
                case 3://genre
                    //list of genres, currently empty
                    List<string> genres = new();
                    //for each genre not on the list already, adds that genre
                    foreach (Film film in list)
                    {
                        if (!genres.Contains(film.Genre.ToLower()))
                        {
                            genres.Add(film.Genre.ToLower());
                        }
                    }
                    //input method
                    in1 = GenreInput(genres);
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Film film in list)
                    {
                        if (film.Genre.ToLower() == in1)
                        {
                            print.Add(film);
                        }
                    }
                    break;
                case 4://release year
                    //input method
                    in2 = IntInput();
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Film film in list)
                    {
                        if (film.Date.Year == in2)
                        {
                            print.Add(film);
                        }
                    }
                    break;
            }
            Console.Clear();
            //if print list is empty
            if (!print.Any())
            {
                Console.WriteLine("Nothing matched your search");
            }
            //if print list is NOT empty
            else
            {
                //time for some variables
                int hours, minutes;
                //print each film in the print list
                foreach (Film film in print)
                {
                    //calculation of time units based on seconds
                    hours = film.Time / 3600;
                    minutes = (film.Time % 3600) / 60;
                    //print of info
                    Console.WriteLine($"Title: {film.Title}\n" +
                        $"Playtime: {hours}t {minutes}min\n" +
                        $"Genre: {film.Genre}\n" +
                        $"Release date: {film.Date.Day}/{film.Date.Month} {film.Date.Year}\n" +
                        $"URL: {film.Url}\n");
                }
            }
            Console.WriteLine("Press any key to return to menu");
            Console.ReadKey();
        }
        public void SongSearch(int choice)
        {
            //get list of all films in database
            List<Song> list = fileHandler.GetSong(),
                print = new();
            //input variables
            string in1;
            int in2;
            //switch based on what the user wants to search for
            switch (choice)
            {
                case 1:
                    print = list;
                    break;
                case 2://title
                    //input method
                    in1 = StringInput();
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Song song in list)
                    {
                        if (song.Title.ToLower().Contains(in1))
                        {
                            print.Add(song);
                        }
                    }
                    break;
                case 3://genre
                    //list of genres, currently empty
                    List<string> genres = new();
                    //for each genre not on the list already, adds that genre
                    foreach (Song song in list)
                    {
                        if (!genres.Contains(song.Genre.ToLower()))
                        {
                            genres.Add(song.Genre.ToLower());
                        }
                    }
                    //input method
                    in1 = GenreInput(genres);
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Song song in list)
                    {
                        if (song.Genre.ToLower() == in1)
                        {
                            print.Add(song);
                        }
                    }
                    break;
                case 4://release year
                    //input method
                    in2 = IntInput();
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Song song in list)
                    {
                        if (song.Date.Year == in2)
                        {
                            print.Add(song);
                        }
                    }
                    break;
                case 5://artist
                    //input method
                    in1 = StringInput();
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Song song in list)
                    {
                        if (song.Artist.ToLower().Contains(in1))
                        {
                            print.Add(song);
                        }
                    }
                    break;
            }
            Console.Clear();
            //if print list is empty
            if (!print.Any())
            {
                Console.WriteLine("Nothing matched your search");
            }
            //if print list is NOT empty
            else
            {
                //time for some variables
                int minutes, seconds;
                //print each film in the print list
                foreach (Song song in print)
                {
                    //calculation of time units based on seconds
                    minutes = song.Time / 60;
                    seconds = song.Time % 60;
                    //print of info
                    Console.WriteLine($"Title: {song.Title}\n" +
                        $"Artist: {song.Artist}\n" +
                        $"Playtime: {minutes}min {seconds}sec\n" +
                        $"Genre: {song.Genre}\n" +
                        $"Album: {song.Album}\n" +
                        $"Release date: {song.Date.Day}/{song.Date.Month} {song.Date.Year}\n" +
                        $"URL: {song.Url}\n");
                }
            }
            Console.WriteLine("Press any key to return to menu");
            Console.ReadKey();
        }
        public void SeriesSearch(int choice)
        {
            //get list of all films in database
            List<Series> list = fileHandler.GetSeries(),
                print = new();
            //input variables
            string in1;
            int in2;
            //switch based on what the user wants to search for
            switch (choice)
            {
                case 1:
                    print = list;
                    break;
                case 2://title
                    //input method
                    in1 = StringInput();
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Series series in list)
                    {
                        if (series.Title.ToLower().Contains(in1))
                        {
                            print.Add(series);
                        }
                    }
                    break;
                case 3://genre
                    //list of genres, currently empty
                    List<string> genres = new();
                    //for each genre not on the list already, adds that genre
                    foreach (Series series in list)
                    {
                        if (!genres.Contains(series.Genre.ToLower()))
                        {
                            genres.Add(series.Genre.ToLower());
                        }
                    }
                    //input method
                    in1 = GenreInput(genres);
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Series series in list)
                    {
                        if (series.Genre.ToLower() == in1)
                        {
                            print.Add(series);
                        }
                    }
                    break;
                case 4://release year
                    //input method
                    in2 = IntInput();
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Series series in list)
                    {
                        if (series.Date.Year == in2)
                        {
                            print.Add(series);
                        }
                    }
                    break;
            }
            Console.Clear();
            //if print list is empty
            if (!print.Any())
            {
                Console.WriteLine("Nothing matched your search");
            }
            //if print list is NOT empty
            else
            {
                //time for some variables
                int hours, minutes;
                //print each film in the print list
                foreach (Series series in print)
                {
                    //calculation of time units based on seconds
                    hours = series.Time / 3600;
                    minutes = (series.Time % 3600) / 60;
                    //print of info
                    Console.WriteLine($"Title: {series.Title}\n" +
                        $"Episode Titel: {series.Info.EpName}\n" +
                        $"Episode Nr: {series.Info.EpNumber}\n" +
                        $"Season: {series.Info.Season}\n" +
                        $"Playtime: {hours}t {minutes}min\n" +
                        $"Genre: {series.Genre}\n" +
                        $"Release date: {series.Date.Day}/{series.Date.Month} {series.Date.Year}\n" +
                        $"URL: {series.Url}\n");
                }
            }
            Console.WriteLine("Press any key to return to menu");
            Console.ReadKey();
        }
        public void GlobalSearch(int choice)
        {
            //get list of all films in database
            List<Film> filmlist = fileHandler.GetFilm(),
                printfilm = new();
            List<Song> songlist = fileHandler.GetSong(),
                printsong = new();
            List<Series> serieslist = fileHandler.GetSeries(),
                printseries = new();
            //input variables
            string in1;
            int in2;
            //switch based on what the user wants to search for
            switch (choice)
            {
                case 1:
                    printfilm = filmlist;
                    printsong = songlist;
                    printseries = serieslist;
                    break;
                case 2://title
                    //input method
                    in1 = StringInput();
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Film film in filmlist)
                    {
                        if (film.Title.ToLower().Contains(in1))
                        {
                            printfilm.Add(film);
                        }
                    }
                    foreach (Song song in songlist)
                    {
                        if (song.Title.ToLower().Contains(in1))
                        {
                            printsong.Add(song);
                        }
                    }
                    foreach (Series series in serieslist)
                    {
                        if (series.Title.ToLower().Contains(in1))
                        {
                            printseries.Add(series);
                        }
                    }
                    break;
                case 3://genre
                    //list of genres, currently empty
                    List<string> genres = new();
                    //for each genre not on the list already, adds that genre (for each type)
                    foreach (Film film in filmlist)
                    {
                        if (!genres.Contains(film.Genre.ToLower()))
                        {
                            genres.Add(film.Genre.ToLower());
                        }
                    }
                    foreach (Song song in songlist)
                    {
                        if (!genres.Contains(song.Genre.ToLower()))
                        {
                            genres.Add(song.Genre.ToLower());
                        }
                    }
                    foreach (Series series in serieslist)
                    {
                        if (!genres.Contains(series.Genre.ToLower()))
                        {
                            genres.Add(series.Genre.ToLower());
                        }
                    }
                    //input method
                    in1 = GenreInput(genres);
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Film film in filmlist)
                    {
                        if (film.Genre.ToLower() == in1)
                        {
                            printfilm.Add(film);
                        }
                    }
                    foreach (Song song in songlist)
                    {
                        if (song.Genre.ToLower() == in1)
                        {
                            printsong.Add(song);
                        }
                    }
                    foreach (Series series in serieslist)
                    {
                        if (series.Genre.ToLower() == in1)
                        {
                            printseries.Add(series);
                        }
                    }
                    break;
                case 4://release year
                    //input method
                    in2 = IntInput();
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Film film in filmlist)
                    {
                        if (film.Date.Year == in2)
                        {
                            printfilm.Add(film);
                        }
                    }
                    foreach (Song song in songlist)
                    {
                        if (song.Date.Year == in2)
                        {
                            printsong.Add(song);
                        }
                    }
                    foreach (Series series in serieslist)
                    {
                        if (series.Date.Year == in2)
                        {
                            printseries.Add(series);
                        }
                    }
                    break;
            }
            Console.Clear();
            //if print list is empty
            if (!printfilm.Any() && !printsong.Any() && !printseries.Any())
            {
                Console.WriteLine("Nothing matched your search");
            }
            //if print list is NOT empty
            else
            {
                //time for some variables
                int hours, minutes, seconds;
                //print each film in the print list
                if (printfilm.Any())
                {
                    Console.WriteLine("Film:\n");
                }
                foreach (Film film in printfilm)
                {
                    //calculation of time units based on seconds
                    hours = film.Time / 3600;
                    minutes = (film.Time % 3600) / 60;
                    //print of info
                    Console.WriteLine($"Title: {film.Title}\n" +
                        $"Playtime: {hours}t {minutes}min\n" +
                        $"Genre: {film.Genre}\n" +
                        $"Release date: {film.Date.Day}/{film.Date.Month} {film.Date.Year}\n" +
                        $"URL: {film.Url}\n");
                }
                if (printsong.Any())
                {
                    Console.WriteLine("Music:\n");
                }
                foreach (Song song in printsong)
                {
                    //calculation of time units based on seconds
                    minutes = song.Time / 60;
                    seconds = song.Time % 60;
                    //print of info
                    Console.WriteLine($"Title: {song.Title}\n" +
                        $"Artist: {song.Artist}\n" +
                        $"Playtime: {minutes}min {seconds}sec\n" +
                        $"Genre: {song.Genre}\n" +
                        $"Album: {song.Album}\n" +
                        $"Release date: {song.Date.Day}/{song.Date.Month} {song.Date.Year}\n" +
                        $"URL: {song.Url}\n");
                }
                if (printseries.Any())
                {
                    Console.WriteLine("Series:\n");
                }
                foreach (Series series in printseries)
                {
                    //calculation of time units based on seconds
                    hours = series.Time / 3600;
                    minutes = (series.Time % 3600) / 60;
                    //print of info
                    Console.WriteLine($"Title: {series.Title}\n" +
                        $"Episode Titel: {series.Info.EpName}\n" +
                        $"Episode Nr: {series.Info.EpNumber}\n" +
                        $"Season: {series.Info.Season}\n" +
                        $"Playtime: {hours}t {minutes}min\n" +
                        $"Genre: {series.Genre}\n" +
                        $"Release date: {series.Date.Day}/{series.Date.Month} {series.Date.Year}\n" +
                        $"URL: {series.Url}\n");
                }
            }
            Console.WriteLine("Press any key to return to menu");
            Console.ReadKey();
        }
        public string StringInput()
        {
            string? input;
            Console.WriteLine("Enter search:");
            while (true)
            {
                input = Console.ReadLine();
                if(input != null)
                {
                    return input.ToLower();
                }
                else
                {
                    Console.WriteLine("\nError. Try again");
                }
            }
        }
        public int IntInput()
        {
            bool looper;
            Console.WriteLine("Enter year:");
            while (true)
            {
                looper = int.TryParse(Console.ReadLine(), out int i);
                if (looper && i >= 1000 && i <= 9999)
                {
                    return i;
                }
                else
                {
                    Console.WriteLine("Error. Try again");
                }
            }
        }
        public string GenreInput(List<string> genres)
        {
            Console.WriteLine("Pick a genre:");
            for (int i = 0; i < genres.Count; i++)
            {
                Console.WriteLine($"'{i + 1}' - {genres[i]}");
            }
            bool looper;
            while (true)
            {
                looper = int.TryParse(Console.ReadKey().KeyChar.ToString(), out int i);
                if (looper && i <= genres.Count && i != 0)//maybe omit 0 / use as quit option
                {
                    return genres[i - 1];
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
