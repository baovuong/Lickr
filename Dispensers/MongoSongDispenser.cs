using System;
using System.Linq;
using System.Collections.Generic;
using Lickr.Models;
using Blog.DotNetCoreMongoDb.Repository;
using MongoDB.Bson;

namespace Lickr.Dispensers
{
    public class MongoSongDispenser : ISongDispenser
    {
        private MongoSongRepository songRepository { get; set; }

        public MongoSongDispenser() 
        {
            songRepository = new MongoSongRepository();
        }
        public Song Dispense() => songRepository.GetRandomSong();

        public void AddSong(Song song) => songRepository.SaveSong(song);
        public void AcceptSong(long id) 
        {
            //TODO
        }
    }
}