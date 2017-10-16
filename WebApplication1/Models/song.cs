using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Song
    {
        private int id;
        private string songName;
    
        
        public Song()
        {

        }
        public Song(int ID,string SongName)
        {
            id = ID;
            songName = SongName;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string SongName
        {
            get { return songName; }
            set { songName = value; }
        }
    }

}