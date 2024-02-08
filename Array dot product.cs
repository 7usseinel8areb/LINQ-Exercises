List<int> list1 = new List<int>()
{
    1,2,3
};
List<int> list2 = new List<int>()
{
    4,5,6
};
var result = list1.Zip(list2,(x,y) => x*y).Sum();
Console.WriteLine(result);