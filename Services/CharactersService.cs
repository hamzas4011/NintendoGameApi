using MongoDB.Driver;
using NintendoGameApi.Models;
using System.Linq;
using System.Collections.Generic;

namespace NintendoGameApi.Services{

    public class CharactersService {

        private readonly IMongoCollection<Character> _characters;

        public CharactersService(INintendoGamestoreDatabaseSettings settings){
            var client = new MongoClient( settings.ConnectionString);
            var database = client.GetDatabase( settings.DatabaseName );

            _characters = database.GetCollection<Character>( settings.CharactersCollectionName);
        }

            public List<Character> Get(){
                return _characters.Find( characters => true ).ToList();
            }

            public Character GetCharacter(string id){
                return _characters.Find( character => character.id == id).SingleOrDefault();
            }

        }

    }
