namespace NintendoGameApi.Models{

    public interface INintendoGamestoreDatabaseSettings{

        string GamesCollectionName { get; set; }
        string ConnectionString { get; set;}

        string DatabaseName { get; set;}
    }

    public class NintendoGamestoreDatabaseSettings : INintendoGamestoreDatabaseSettings {
        public string GamesCollectionName { get; set;}
        public string ConnectionString { get; set;}
        public string DatabaseName { get; set;}

    }

}