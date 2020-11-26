using MongoDB.Driver;
using NintendoGameApi.Models;
using System.Linq;
using System.Collections.Generic;

namespace NintendoGameApi.Services{

    public class ConsolesService {

        private readonly IMongoCollection<Console> _consoles;

        public ConsolesService(INintendoGamestoreDatabaseSettings settings){
            var client = new MongoClient( settings.ConnectionString);
            var database = client.GetDatabase( settings.DatabaseName );

            _consoles = database.GetCollection<Console>( settings.ConsolesCollectionName);
        }

            public List<Console> Get(){
                return _consoles.Find( consoles => true ).ToList();
            }

            public Console GetConsole(string id){
                return _consoles.Find( console => console.id == id).SingleOrDefault();
            }

        }

    }
