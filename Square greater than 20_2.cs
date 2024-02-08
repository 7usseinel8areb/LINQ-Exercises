List<int> list = new List<int>()
{
    7,2,30
};
var result = list.Where(i => i * i >= 20)
                 .Select(i => new { num = i, pow = i * i });
Console.WriteLine(string.Join('\n', result));