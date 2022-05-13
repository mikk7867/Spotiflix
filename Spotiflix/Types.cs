using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//objects to be used by the rest of the program (film, music, series)
//getter and setter transforms a field to a property
/*
{ get; set; }
<==>
{
    get
    {
        return _name;
    }
    set
    {
        _name = value;
    }
}
whenever an object is created, the constructor (fx lines 36-43) determines the structure of the new object
 
 
 
 
*/
namespace Spotiflix
{
    internal class Film//film object
    {
        public string Title { get; set; }
        public int Time { get; set; }
        public string Genre { get; set; }
        public ReleaseDate Date { get; set; }
        public string Url { get; set; }
        public Film(string title, int playTime, string genre, ReleaseDate releaseDate, string url)
        {
            Title = title;
            Time = playTime;
            Genre = genre;
            Date = releaseDate;
            Url = url;
        }
    }
    internal class Song//songs object
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Time { get; set; }
        public string Genre { get; set; }
        public string Album { get; set; }
        public ReleaseDate Date { get; set; }
        public string Url { get; set; }
        public Song(string title, string artist, int playTime, string genre, string album, ReleaseDate releaseDate, string url)
        {
            Title = title;
            Artist = artist;
            Time = playTime;
            Genre = genre;
            Album = album;
            Date = releaseDate;
            Url = url;
        }
    }
    internal class Series//series/episode object
    {
        public string Title { get; set; }
        public EpInfo Info { get; set; }
        public int Time { get; set; }
        public string Genre { get; set; }
        public ReleaseDate Date { get; set; }
        public string Url { get; set; }
        public Series(string title, EpInfo epinfo, int playTime, string genre, ReleaseDate releaseDate, string url)
        {
            Title = title;
            Info = epinfo;
            Time = playTime;
            Genre = genre;
            Date = releaseDate;
            Url = url;
        }
    }
    internal class EpInfo//epinfo used in the series object
    {
        public string EpName { get; set; }
        public int EpNumber { get; set; }
        public int Season { get; set; }
        public EpInfo(string epname, int epnumber, int season)
        {
            EpName = epname;
            EpNumber = epnumber;
            Season = season;
        }
    }
    internal class ReleaseDate//releasedate dd/mm/yyyy used in all three category objects
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public ReleaseDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
    }
}
