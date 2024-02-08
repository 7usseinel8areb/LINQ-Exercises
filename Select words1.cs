List<string> list = new List<string>()
{
    "mum", "Amsterdam", "bloom"
};
var result = from i in list
             where i.ToLower().StartsWith('a')
                && i.ToLower().EndsWith('m')
             select i;
Console.WriteLine(string.Join(',',result));