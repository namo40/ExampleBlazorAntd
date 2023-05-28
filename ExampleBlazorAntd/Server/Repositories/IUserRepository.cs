using ExampleBlazorAntd.Shared.Models;

namespace ExampleBlazorAntd.Server.Repositories;

public interface IUserRepository
{
    /// <summary>
    /// Find users by name
    /// </summary>
    /// <param name="searchName"></param>
    /// <returns></returns>
    List<UserRecord> FindUsers(string searchName);
}