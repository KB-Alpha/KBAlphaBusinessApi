using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KBAlphaBusinessApi.Helpers;
using KBAlphaBusinessApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace KBAlphaBusinessApi.Services
{
    public class Database<T>
    {
        private readonly IMongoCollection<T> _dataCollection;

        //The constructor arguments are found on mongodb
        //Could use the appsettings file to store values
        public Database(IOptions<DatabaseSettings> databaseSettings)
        {
            //start the database client
            var mongoClient = new MongoClient(Constants.MongoConnectionString);

            //The database
            var mongoDatabase = mongoClient.GetDatabase("sample_airbnb");
            System.Diagnostics.Debug.WriteLine("Database name: ", mongoDatabase);

            _dataCollection = mongoDatabase.GetCollection<T>("listingsAndReviews");

        }

        //Have CRUD methods with generic classes
        public async Task<List<T>> GetAsync() =>
        await _dataCollection.Find(_ => true).ToListAsync();

        public async Task<T> GetAsync(string id) =>
            await _dataCollection.Find(x =>x.ToString() == id).FirstOrDefaultAsync();

        public async Task CreateAsync(T data) =>
            await _dataCollection.InsertOneAsync(data);

        public async Task UpdateAsync(string id, T updatedBook) =>
            await _dataCollection.ReplaceOneAsync(x => x.ToString() == id, updatedBook);

        public async Task RemoveAsync(string id) =>
            await _dataCollection.DeleteOneAsync(x => x.ToString() == id);
    }
}
