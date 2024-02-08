List<string> list = new List<string>()
{
    "plane", "ferry", "car", "bike"
};
var result = list.Order()
                 .Where(i => i.Contains('e'))
                 .Last();
Console.WriteLine(result);