using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NintendoGameApi.Models{

    public class Console{

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set;}

        public string Name { get; set;}
        public int Year { get; set;}
        public int Price { get; set;}



    }
}