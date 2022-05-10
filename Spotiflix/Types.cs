using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//objects to be used by the rest of the program (film, music, series)

namespace Spotiflix
{
    internal class Film
    {
        public string Title { get; set; }
        public PlayTime Time { get; set; }
        public string Genre { get; set; }
        public ReleaseDate Date { get; set; }
        public string Url { get; set; }
        public Film(string title, PlayTime playTime, string genre, ReleaseDate releaseDate, string url)
        {
            Title = title;
            Time = playTime;
            Genre = genre;
            Date = releaseDate;
            Url = url;
        }
    }
    internal class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public PlayTime Time { get; set; }
        public string Genre { get; set; }
        public string Album { get; set; }
        public ReleaseDate Date { get; set; }
        public string Url { get; set; }
        public Song(string title, string artist, PlayTime playTime, string genre, string album, ReleaseDate releaseDate, string url)
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
    internal class Series
    {
        public string Title { get; set; }
        public EpInfo Info { get; set; }
        public PlayTime Time { get; set; }
        public string Genre { get; set; }
        public ReleaseDate Date { get; set; }
        public string Url { get; set; }
        public Series(string title, EpInfo epinfo, PlayTime playTime, string genre, ReleaseDate releaseDate, string url)
        {
            Title = title;
            Info = epinfo;
            Time = playTime;
            Genre = genre;
            Date = releaseDate;
            Url = url;
        }
    }
    internal class EpInfo
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
    internal class PlayTime
    {
        public int Unit1 { get; set; }
        public int Unit2 { get; set; }
        public PlayTime(int unit1, int unit2)
        {
            Unit1 = unit1;
            Unit2 = unit2;
        }
    }
    internal class ReleaseDate
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
