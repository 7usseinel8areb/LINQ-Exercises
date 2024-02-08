string str = "gamma";
var result = str.GroupBy(i => i);
foreach ( var item in result )
{
    Console.WriteLine($"Letter: {item.Key}, frequency: {item.Count()}");
}