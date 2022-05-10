
//methods for anything and everything file-related

namespace Spotiflix
{
    internal class FileHandler
    {
        public void Startup()
        {
            List<string> files = new() { "filmlist.txt", "songlist.txt", "serieslist.txt" };
            foreach (string s in files)
            {
                if (!File.Exists(s))
                {
                    File.Create(s);
                }
            }
        }
        public List<Film> GetFilm()
        {
            List<string> items = Reader("filmlist.txt");
            List<Film> film = new();
            Film temp;
            PlayTime playTime;
            ReleaseDate releaseDate;
            for (int i = 0; i < (items.Count / 8); i++)
            {
                playTime = new(int.Parse(items[(i * 8) + 1]), int.Parse(items[(i * 8) + 2]));
                releaseDate = new(int.Parse(items[(i * 8) + 4]), int.Parse(items[(i * 8) + 5]), int.Parse(items[(i * 8) + 6]));
                temp = new(items[i * 8], playTime, items[(i * 8) + 3], releaseDate, items[(i * 8) + 7]);
                film.Add(temp);
            }
            return film;
        }
        public List<Song> GetSong()
        {
            List<string> items = Reader("songlist.txt");
            List<Song> song = new();
            Song temp;
            PlayTime playTime;
            ReleaseDate releaseDate;
            for (int i = 0; i < (items.Count / 10); i++)
            {
                playTime = new(int.Parse(items[(i * 10) + 2]), int.Parse(items[(i * 10) + 3]));
                releaseDate = new(int.Parse(items[(i * 10) + 6]), int.Parse(items[(i * 10) + 7]), int.Parse(items[(i * 10) + 8]));
                temp = new(items[i * 10], items[(i * 10) + 1], playTime, items[(i * 10) + 4], items[(i * 10) + 5], releaseDate, items[(i * 10) + 9]);
                song.Add(temp);
            }
            return song;
        }
        public List<Series> GetSeries()
        {
            List<string> items = Reader("serieslist.txt");
            List<Series> series = new();
            Series temp;
            EpInfo epInfo;
            PlayTime playTime;
            ReleaseDate releaseDate;
            for (int i = 0; i < (items.Count / 11); i++)
            {
                epInfo = new(items[(i * 11) + 1], int.Parse(items[(i * 11) + 2]), int.Parse(items[(i * 11) + 3]));
                playTime = new(int.Parse(items[(i * 11) + 4]), int.Parse(items[(i * 11) + 5]));
                releaseDate = new(int.Parse(items[(i * 11) + 7]), int.Parse(items[(i * 11) + 8]), int.Parse(items[(i * 11) + 9]));
                temp = new(items[i * 11], epInfo, playTime, items[(i * 11) + 6], releaseDate, items[(i * 11) + 10]);
                series.Add(temp);
            }
            return series;
        }
        public List<string> Reader(string url)
        {
            string s = File.ReadAllText(url);
            return s.Split('_').ToList();
        }
    }
}
