using ExampleBlazorAntd.Shared.Models;

namespace ExampleBlazorAntd.Server.Repositories;

public sealed class UserRepository : IUserRepository
{
    private readonly List<UserRecord> _users = new();

    public UserRepository()
    {
        const int dummyCount = 1000;

        for (var i = 0; i < dummyCount; i++)
        {
            _users.Add(new UserRecord(Faker.Name.First(), 1, Faker.RandomNumber.Next(1, 100)));
        }
    }

    public List<UserRecord> FindUsers(string searchName)
    {
        return _users.Where(u => u.Name.Contains(searchName)).ToList();
    }
}