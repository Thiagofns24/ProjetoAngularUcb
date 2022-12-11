namespace Mission.API2.Data.Configurations
{
    public class DatabaseConfig : IDatabaseConfig
    {
        public string DatabaseName { get; set; }


        public string connectionString { get; set; }
    }
}


