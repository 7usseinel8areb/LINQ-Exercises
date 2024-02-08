List<int> list = new List<int>()
{
    7,2,30
};
var result = from i in list
             where i*i >20
             select new {num = i , pow = i*i};
Console.WriteLine(string.Join('\n',result));