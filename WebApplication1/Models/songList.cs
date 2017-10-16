using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SongList
    {
        private static List<Song> songs = new List<Song>()
        {
            new Song {ID=1, SongName="Moonlign Sonata"},
            new Song {ID=2, SongName="Put Your Head On My Shoulder"},
            new Song {ID=3, SongName="Earth Angel"}


        };
        public static void AddSongName(Song newSong)
        {
            songs.Add(newSong);
        }

        public static List<Song> GetAllSongs()
        {
            return songs;
        }

        public static Song GetASong(int id)
        {
            Song r = new Song();
            foreach (Song s in songs)
                if (s.ID == id)
                    r = s;
            return r;
        }

        //public static bool Update(int id, Song UpdateSong)
        //{
        //    bool returnValue = false;

        //    foreach (Song s in songs)
        //        if (s.ID == id)
        //    {
        //            s.SongName = UpdateSong.SongName;
        //            returnValue = true;
        //    }
        //    return returnValue;
        //}
    }
}