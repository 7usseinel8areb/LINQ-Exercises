List<int> lst = new List<int>()
{
    67, 92, 135, 15
};
var result = from i in lst
             where i > 30 && i < 100
             select i;
Console.WriteLine(string.Join(",", result));