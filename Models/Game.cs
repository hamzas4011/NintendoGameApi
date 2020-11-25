using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NintendoGameApi.Models{

    public class Game{

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set;}

        public string Name { get; set;}
        public string Category { get; set;}
        public int Price { get; set;}



    }
}