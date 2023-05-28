using System.ComponentModel;

namespace ExampleBlazorAntd.Shared.Models;

public record UserRecord(
    [property: DisplayName("User Name")] string Name,
    [property: DisplayName("Job")] int Job,
    [property: DisplayName("Level")] int Level
);