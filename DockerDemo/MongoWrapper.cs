using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DockerDemo
{
    public class MongoWrapper
    {
        private readonly string connectionString;

        public MongoWrapper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Users> GetData(string database, string collection)
        {
            var client = new MongoClient(this.connectionString);
            var db = client.GetDatabase(database);
            var coll = db.GetCollection<Users>(collection);
            return coll.Find(_=>true).ToList();
        }

        public void InsertData<T>(string database, string collection,T data)
        {
            var client = new MongoClient(this.connectionString);
            var db = client.GetDatabase(database);
            db.GetCollection<T>(collection).InsertOne(data);
        }
    }
}
