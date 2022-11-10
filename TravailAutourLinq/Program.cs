var list = new List<string>()
{
    "Gimli",
    "Théoden",
    "Gandalf",
    "Legolas"
};

Console.WriteLine("------------------------------------------");
foreach (var item in list)
{
    Console.WriteLine(item);
}

list.ForEach(item => Console.WriteLine(item));

Console.WriteLine("------------------------------------------");
var monCallBack = (string item) => Console.WriteLine(item);
Action<string> monCallBack2 = item => Console.WriteLine(item);

list.ForEach(monCallBack2);


Console.WriteLine("------------------------------------------");

Func<string, string> conversion = item => item + " !";
list = list.Select(conversion).ToList(); // C'est pas performant !!


var listEnumerableSansSavoirSonVraiType = list.Select(conversion);
foreach (var item in listEnumerableSansSavoirSonVraiType)
{
    Console.WriteLine(item);
}


