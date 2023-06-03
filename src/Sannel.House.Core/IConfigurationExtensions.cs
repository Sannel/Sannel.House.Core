using Microsoft.Extensions.Configuration;

namespace Sannel.House;
public static class IConfigurationExtensions
{

	/// <summary>
	/// Gets the configured group ID.
	/// </summary>
	/// <param name="configuration">The configuration.</param>
	/// <param name="groupId">The group identifier.</param>
	/// <returns>The group ID, or an empty string if not found.</returns>
	public static string GetGroupById(this IConfiguration configuration, string groupId)
	{
		ArgumentNullException.ThrowIfNull(configuration);
		ArgumentException.ThrowIfNullOrEmpty(groupId);

		return configuration[$"Roles:{groupId}"] ?? string.Empty;
	}
}
