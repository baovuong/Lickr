using System;
using System.Collections.Generic;
using Lickr.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Lickr.Dal
{
    public class MongoDbContext : ISongRepository
    {

        private readonly IMongoDatabase _database = null;

        public MongoDbContext()
        {
            var client = new MongoClient("CONN STRING FROM SETTINGS");
            if (client != null)
                _database = client.GetDatabase("DB STRING FROM SETTINGS");
        }

        public IMongoCollection<SongViewModel> Notes
        {
            get
            {
                return _database.GetCollection<SongViewModel>("Songs");
            }
        }

        public IEnumerable<SongViewModel> Songs { get; set; }
    }
}