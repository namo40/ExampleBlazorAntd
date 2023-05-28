using ExampleBlazorAntd.Server.Repositories;
using Faker;
using Microsoft.AspNetCore.Mvc;

namespace ExampleBlazorAntd.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
    }

    [HttpGet("findUsers")]
    public async Task<ActionResult> FindUsersAsync([FromQuery] string? searchName)
    {
        await Task.Delay(TimeSpan.FromMilliseconds(RandomNumber.Next(100, 5000)));

        return Ok(_userRepository.FindUsers(searchName ?? string.Empty));
    }
}