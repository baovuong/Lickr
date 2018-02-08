using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using MongoDB.Bson.Serialization;
using Lickr.Models;

namespace Blog.DotNetCoreMongoDb.Repository
{
    public class MongoSongRepository
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;
        protected IMongoCollection<Song> _collection;

        public MongoSongRepository()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("lickrDb");
            _collection = _database.GetCollection<Song>("songs");
        }

        public IEnumerable<Song> SelectAll()
        {
            var query = this._collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }

    }
}