using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SongsController : ApiController
    {
        // GET: api/Songs
        public IEnumerable<Song> Get()
        {
            // return new string[] { "value1", "value2" };
            return SongList.GetAllSongs();
        }

        // GET: api/Songs/5
        public Song Get(int id)
        {
            // return "value";
            return SongList.GetASong(id);
            
        }

        // POST: api/Songs
        //public void Post([FromBody]string value)
        //{
        //}
        public Song Post(Song value)
        {
            SongList.AddSongName(value);
            return SongList.GetASong(value.ID);
                
        }

        // PUT: api/Songs/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

            public void Put(int id, Song value)
        {
            SongList.Update(id, value);
        }

        // DELETE: api/Songs/5
        public void Delete(int id)
        {
            SongList.DeleteSong(id);
        }
    }
}
