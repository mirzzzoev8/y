using Task1;
var aaa = new Cache<string>();
aaa.AddCache("Salom");
aaa.AddCache("Voalek");
aaa.AddCache("Muallim");

aaa.RemoveCache("Salom");

foreach (var item in aaa.GetCache())
{
    System.Console.WriteLine(item);
}


