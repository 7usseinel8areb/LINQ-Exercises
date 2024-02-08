List<int> lst = new List<int>()
{
    67, 92, 135, 15
};
var result = lst.Where(i => (i > 30 && i < 100));
Console.WriteLine(string.Join(",", result));