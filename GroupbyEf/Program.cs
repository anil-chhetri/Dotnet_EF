using System.Text.Json;

Console.WriteLine("Hello, World!");

var factory = new DataContextFactory();
var context = factory.CreateDbContext(args);


//adding json to database.
if (context.Database.EnsureCreated())
{
    System.Console.WriteLine("here");
    using FileStream fileStream = File.OpenRead(@"Data\data.json");
    var censusData = JsonSerializer.Deserialize<CensusData[]>(fileStream);
    context.CensusData.AddRange(censusData);
    context.SaveChanges();
    System.Console.WriteLine("Completed");
}

// context.Database.EnsureDeleted();