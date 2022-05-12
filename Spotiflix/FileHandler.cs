
//methods for anything and everything file-related

namespace Spotiflix
{
    internal class FileHandler
    {
        public void Startup()//to be run at startup, ensuring no crashes due to reading from a non-existing file 
        {
            //a string list of the file names used in this program
            List<string> files = new() { "filmlist.txt", "songlist.txt", "serieslist.txt" };
            //for each file name
            foreach (string s in files)
            {
                //if the file does not exist
                if (!File.Exists(s))
                {
                    //that file is then created
                    File.Create(s);
                }
            }
        }
        public List<Film> GetFilm()//get and return a list of film
        {
            //get a string list from the text file
            List<string> items = Reader("filmlist.txt");
            //variables
            List<Film> film = new();
            Film temp;
            ReleaseDate releaseDate;
            //for each full film (7 items) in the string list
            for (int i = 0; i < (items.Count / 7); i++)
            {
                //releasedate set to the appropriate items converted to int
                releaseDate = new(int.Parse(items[(i * 7) + 3]), int.Parse(items[(i * 7) + 4]), int.Parse(items[(i * 7) + 5]));
                //temporary film set to the appropriate items, including the releasedate
                temp = new(items[i * 7], int.Parse(items[(i * 7) + 1]), items[(i * 7) + 2], releaseDate, items[(i * 7) + 6]);
                //temporary film is added to list
                film.Add(temp);
            }
            //the list is returned
            return film;
        }
        public List<Song> GetSong()
        {
            //get a string list from the text file
            List<string> items = Reader("songlist.txt");
            //variables
            List<Song> song = new();
            Song temp;
            ReleaseDate releaseDate;
            //for each full song (9 items) in the string list
            for (int i = 0; i < (items.Count / 9); i++)
            {
                //releasedate set to the appropriate items converted to int
                releaseDate = new(int.Parse(items[(i * 9) + 5]), int.Parse(items[(i * 9) + 6]), int.Parse(items[(i * 9) + 7]));
                //temporary song set to the appropriate items, including the releasedate
                temp = new(items[i * 9], items[(i * 9) + 1], int.Parse(items[(i * 9) + 2]), items[(i * 9) + 3], items[(i * 9) + 4], releaseDate, items[(i * 9) + 8]);
                //temporary song is added to list
                song.Add(temp);
            }
            //the list is returned
            return song;
        }
        public List<Series> GetSeries()
        {
            //get a string list from the text file
            List<string> items = Reader("serieslist.txt");
            //variables
            List<Series> series = new();
            Series temp;
            EpInfo epInfo;
            ReleaseDate releaseDate;
            //for each full series (10 items) in the string list
            for (int i = 0; i < (items.Count / 10); i++)
            {
                //epinfo set to the appropriate items, converted to int if applicable
                epInfo = new(items[(i * 10) + 1], int.Parse(items[(i * 10) + 2]), int.Parse(items[(i * 10) + 3]));
                //releasedate set to the appropriate items converted to int
                releaseDate = new(int.Parse(items[(i * 10) + 6]), int.Parse(items[(i * 10) + 7]), int.Parse(items[(i * 10) + 8]));
                //temporary song set to the appropriate items, including theepinfo, playtime and releasedate
                temp = new(items[i * 10], epInfo, int.Parse(items[(i * 10) + 4]), items[(i * 10) + 5], releaseDate, items[(i * 10) + 9]);
                //temporary series is added to list
                series.Add(temp);
            }
            //the list is returned
            return series;
        }
        public List<string> Reader(string url)//the file-reading capital
        {
            //the entire file is copied into the string
            string s = File.ReadAllText(url);
            //the string is split up at underscores, and then returned
            return s.Split('§').ToList();
        }
    }
}
