List<string> list = new List<string>()
{
    "learn", "current", "deal"
};
var result = from i in list
             select i.Replace("ea", "*");
Console.WriteLine(string.Join(',', result));