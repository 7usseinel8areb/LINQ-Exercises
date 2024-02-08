List<string> list = new List<string>()
{
    "learn", "current", "deal"
};
var result = list.Select(i => i.Replace("ea", "*"));
Console.WriteLine(string.Join(',', result));