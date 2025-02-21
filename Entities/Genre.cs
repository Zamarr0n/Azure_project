namespace GameStore.Api.Entities;

public class Genre
{
    // as the game properties, here we specify the genre properties
    public int Id { get; set; }

    public required string Name { get; set; }
}
