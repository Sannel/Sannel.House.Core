namespace Sannel.House;

public static class Roles
{
	public const string ADMIN = "House.Admin";

	public static class Sprinklers
	{
		public const string SCHEDULE_READ = "House.Sprinklers.Schedule.Read";
		public const string SCHEDULE_WRITE = "House.Sprinklers.Schedule.Write";
		public const string ZONE_READ = "House.Sprinklers.Zone.Read";
		public const string ZONE_WRITE = "House.Sprinklers.Zone.Write";

	}
}
