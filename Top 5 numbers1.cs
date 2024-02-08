List<int> lst = new List<int>()
{
    78, -9, 0, 23, 54, 21, 7, 86
};

var result = (from i in lst
             orderby i descending
             select i).Take(5);
Console.WriteLine(string.Join(",", result));