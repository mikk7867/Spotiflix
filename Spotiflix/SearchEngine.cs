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
                case 1://title
                    //input method
                    in1 = StringInput();
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach(Film film in list)
                    {
                        if(film.Title.ToLower() == in1)
                        {
                            print.Add(film);
                        }
                    }
                    break;
                case 2://genre
                    //input method
                    in1 = StringInput();
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Film film in list)
                    {
                        if (film.Genre.ToLower() == in1)
                        {
                            print.Add(film);
                        }
                    }
                    break;
                case 3://release year
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
            //if print list is empty
            if (!print.Any())
            {
                Console.WriteLine("Nothing matched your search.\n" +
                    "Please try again");
            }
            //if print list is NOT empty
            else
            {
                //print each film in the print list
                foreach (Film film in print)
                {
                    Console.WriteLine($"Title: {film.Title}\n" +
                        $"Playtime: {film.Time.Unit1}t {film.Time.Unit2}min\n" +
                        $"Genre: {film.Genre}\n" +
                        $"Release date: {film.Date.Day}/{film.Date.Month} {film.Date.Year}\n" +
                        $"URL: {film.Url}\n");
                }
            }
        }
        public void SongSearch(int choice)
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
                case 1://title
                    //input method
                    in1 = StringInput();
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Film film in list)
                    {
                        if (film.Title.ToLower() == in1)
                        {
                            print.Add(film);
                        }
                    }
                    break;
                case 2://genre
                    //input method
                    in1 = StringInput();
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Film film in list)
                    {
                        if (film.Genre.ToLower() == in1)
                        {
                            print.Add(film);
                        }
                    }
                    break;
                case 3://release year
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
            //if print list is empty
            if (!print.Any())
            {
                Console.WriteLine("Nothing matched your search.\n" +
                    "Please try again");
            }
            //if print list is NOT empty
            else
            {
                //print each film in the print list
                foreach (Film film in print)
                {
                    Console.WriteLine($"Title: {film.Title}\n" +
                        $"Playtime: {film.Time.Unit1}t {film.Time.Unit2}min\n" +
                        $"Genre: {film.Genre}\n" +
                        $"Release date: {film.Date.Day}/{film.Date.Month} {film.Date.Year}\n" +
                        $"URL: {film.Url}\n");
                }
            }
        }
        public void SeriesSearch(int choice)
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
                case 1://title
                    //input method
                    in1 = StringInput();
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Film film in list)
                    {
                        if (film.Title.ToLower() == in1)
                        {
                            print.Add(film);
                        }
                    }
                    break;
                case 2://genre
                    //input method
                    in1 = StringInput();
                    //for each film in the list, if it maches the input, add it to the to-be-printed-list
                    foreach (Film film in list)
                    {
                        if (film.Genre.ToLower() == in1)
                        {
                            print.Add(film);
                        }
                    }
                    break;
                case 3://release year
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
            //if print list is empty
            if (!print.Any())
            {
                Console.WriteLine("Nothing matched your search.\n" +
                    "Please try again");
            }
            //if print list is NOT empty
            else
            {
                //print each film in the print list
                foreach (Film film in print)
                {
                    Console.WriteLine($"Title: {film.Title}\n" +
                        $"Playtime: {film.Time.Unit1}t {film.Time.Unit2}min\n" +
                        $"Genre: {film.Genre}\n" +
                        $"Release date: {film.Date.Day}/{film.Date.Month} {film.Date.Year}\n" +
                        $"URL: {film.Url}\n");
                }
            }
        }
        public string StringInput()
        {
            string? input;
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
            while (true)
            {
                looper = int.TryParse(Console.ReadLine(), out int i);
                if (looper)
                {
                    return i;
                }
                else
                {
                    Console.WriteLine("Error. Try again");
                }
            }
        }
    }
}
