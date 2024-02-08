var str = "DDD example CQRS Event Sourcing".Split(' ');
var result = str.Where(i => i == i.ToUpper());
Console.WriteLine(string.Join(",", result));