using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DockerDemo
{
    [BsonIgnoreExtraElements]
    public class Users
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("userid")]
        public int Userid { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("interests")]
        public string Interests { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }
    }
}
