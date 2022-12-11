namespace Mission.API2.Data.Configurations
{
	public interface IDatabaseConfig
	{

		string DatabaseName { get; set; }

		string connectionString { get; set; }
	}
}

