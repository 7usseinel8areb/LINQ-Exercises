List<string> lst = new List<string>()
{
    "computer", "usb"
};
var result = from i in lst
             where i.Length >= 5
             select i.ToUpper();
Console.WriteLine(string.Join(",", result));