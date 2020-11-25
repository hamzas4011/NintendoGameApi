using MongoDB.Driver;
using NintendoGameApi.Models;
using System.Linq;
using System.Collections.Generic;

namespace NintendoGameApi.Services{

    public class GamesService {

        private readonly IMongoCollection<Game> _games;

        public GamesService(INintendoGamestoreDatabaseSettings settings){
            var client = new MongoClient( settings.ConnectionString);
            var database = client.GetDatabase( settings.DatabaseName );

            _games = database.GetCollection<Game>( settings.GamesCollectionName);
        }

            public List<Game> Get(){
                return _games.Find( games => true ).ToList();
            }

            public Game GetGame(string id){
                return _games.Find( game => game.id == id).SingleOrDefault();
            }

        }

    }
