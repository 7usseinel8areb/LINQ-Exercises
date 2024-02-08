List<string> lst = new List<string>()
{
    "computer", "usb"
};
var result = lst.Where(i => i.Length >= 5)
                .Select(i => i.ToUpper());
Console.WriteLine(string.Join(",", result));