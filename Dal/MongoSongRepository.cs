using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using MongoDB.Bson.Serialization;

namespace Blog.DotNetCoreMongoDb.Repository
{
    public class MongoSongRepository
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

    }
}