List<string> list = new List<string>()
{
    "abc", "xyz", "klm", "xyz", "abc", "abc", "rst"
};
var result = list.GroupBy(i => i).Where(i => i.Count()==1);
foreach (var item in result)
{
    Console.WriteLine(item.Key);
}