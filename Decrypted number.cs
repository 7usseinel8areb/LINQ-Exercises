List<char> list =new List<char> ()
{
    ')', '!', '@', '#', '$', '%', '^', '&', '*', '('
};
while (true)
{
    Console.Write("Enter the sample here: ");
    var encrypted =Console.ReadLine();
    var result = encrypted.Select(i => list.IndexOf(i));
    Console.WriteLine(string.Join("",result));
}