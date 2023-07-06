using FunctionExamples;
using FunctionExamples.ConsoleApp4;

int avg = 0;
int sum = 0;
int prod = 0;
int big = 0;
Function function = new Function();
sum=function.SumAndAvg(10, 20, ref avg,ref prod,out big);

Console.WriteLine(sum);
Console.WriteLine(avg);
Console.WriteLine(prod);
Console.WriteLine(big);

Polymorphism polymorphism = new Polymorphism();

Console.Write(polymorphism.Add((float)21.1, (float)32.6));
Console.WriteLine();    

KingsMan king = new KingsMan();
Console.WriteLine(king.GetAgentName());

Intern intern = new Intern();
Console.WriteLine(intern.GetAgentName());

king=new Intern();

Console.WriteLine(king.GetAgentName());

CollectionExample example = new CollectionExample();
example.ExampleOfArray();


Guardians guardians = new Guardians();

guardians.Missionaccomplished = "Successful";
int Star= Guardians.Assemble(10, 20);
Console.WriteLine(Star);

//Disciple disciple = new Disciple();

//disciple.Command();

Follower follower = new Follower();
follower.Command();
