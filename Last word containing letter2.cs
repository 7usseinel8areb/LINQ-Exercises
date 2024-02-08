List<string> list = new List<string>()
{
    "plane", "ferry", "car", "bike"
};
var result = (from i in list
              where i.Contains('e')
              orderby i
              select i).Last();
Console.WriteLine(result);