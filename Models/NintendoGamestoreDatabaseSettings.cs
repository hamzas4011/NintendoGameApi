namespace NintendoGameApi.Models{

    public interface INintendoGamestoreDatabaseSettings{

        string GamesCollectionName { get; set; }
        string ConsolesCollectionName { get; set; }
        string CharactersCollectionName { get; set; }
        
        string ConnectionString { get; set;}

        string DatabaseName { get; set;}
    }

    public class NintendoGamestoreDatabaseSettings : INintendoGamestoreDatabaseSettings {
        public string GamesCollectionName { get; set;}
        public string ConsolesCollectionName { get; set; }
        public string CharactersCollectionName { get; set; }
        public string ConnectionString { get; set;}
        public string DatabaseName { get; set;}

    }

}