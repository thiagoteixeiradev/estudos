using Facade;

ScoreClienteFacade score = new();

var Score = score.Score("157478945", "1547896589");

Console.WriteLine($"Score do cliente é: " + Score);