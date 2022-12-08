// See https://aka.ms/new-console-template for more information


var lines = await File.ReadAllLinesAsync("..\\..\\..\\input1.txt");
Console.WriteLine("Input:");

foreach (var line in lines)
{
    Console.WriteLine(line);
}