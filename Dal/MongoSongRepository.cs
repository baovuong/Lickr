using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using MongoDB.Bson.Serialization;
using Lickr.Models;
using System;

namespace Blog.DotNetCoreMongoDb.Repository
{
    public class MongoSongRepository
    {
        protected static IMongoClient client { get; private set; }
        protected static IMongoDatabase database { get; private set; }
        protected IMongoCollection<Song> collection { get; private set; }

        public MongoSongRepository()
        {
            client = new MongoClient();
            database = client.GetDatabase("lickrDb");
            collection = database.GetCollection<Song>("songs");
        }

        public IEnumerable<Song> SelectAll() => 
            collection.Find(new BsonDocument()).ToList();

        public void SaveSong(Song song) => collection.InsertOne(song);
        
        public Song GetRandomSong() => 
            collection.Find(new BsonDocument()).SortBy(s => Guid.NewGuid()).First();


    }
}