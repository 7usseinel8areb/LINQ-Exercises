while (true)
{
    Console.Write("Enter the string here: ");
    var str = Console.ReadLine();
    var result = str.GroupBy(i => i).OrderByDescending(i => i.Count());
    Console.WriteLine(result.First().Key);
}