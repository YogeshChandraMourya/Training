using IndexersExample;
using System;

Cars cars = new Cars();

cars[0] = new CarParts
{
    Name = "Lamborghini",
Part1 = "bonet",
Part2 = "chasis",
Part3 = "rear window",
Part4= "front window"

};
cars[1] = new CarParts
{
    Name = "Mercedes",
    Part1 = "bonet",
    Part2 = "sunroof",
    Part3 = "rear window",
    Part4 = "front window"

};
cars[2] = new CarParts
{
    Name = "Ferrari",
    Part1 = "bonet",
    Part2 = "wiper",
    Part3 = "rear window",
    Part4 = "front window"

};
cars[3] = new CarParts
{
    Name = "Porshe",
    Part1 = "bonet",
    Part2 = "bumper",
    Part3 = "rear window",
    Part4 = "front window"

};
cars[4] = new CarParts
{
    Name = "McLaren",
    Part1 = "bonet",
    Part2 = "spoiler",
    Part3 = "rear window",
    Part4 = "front window"

};

for(int i = 0; i < 5; i++)
{
    Console.WriteLine("___________________________________");
    Console.WriteLine(cars[i].Name+"  " + cars[i].Part2);
    Console.WriteLine("___________________________________");
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();