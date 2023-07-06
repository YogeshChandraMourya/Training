using Miscelaneous;

int? x = null;
if (x == null)
{
    Console.WriteLine("Im null");
    Console.WriteLine(x.ToString());
    Console.WriteLine("I think above is an empty value");
}

string nill = null;
Nothing nothing = null;

if (nothing != null){
    Console.WriteLine(nothing.MyProperty);
}


nill = null;
nill = string.Empty;
if (string.IsNullOrEmpty(nill))
{
    Console.WriteLine("Can i execute");
}

string ?i= null;
string j = i ?? "I dont want to be null";

Console.WriteLine(j);

var processes= from p in System.Diagnostics.Process.GetProcesses()
               select new {pName=p.ProcessName, pId=p.Id};
foreach (var process in processes)
{
    Console.WriteLine(process);
}