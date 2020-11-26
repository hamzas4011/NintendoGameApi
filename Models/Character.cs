using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NintendoGameApi.Models{

    public class Character{

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set;}

        public string Name { get; set;}
        public int Age { get; set;}
        public string Weapon { get; set;}
        public string Strength { get; set;}



    }
}