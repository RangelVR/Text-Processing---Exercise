string[] file = Console.ReadLine().Split("\\");

string fileNameAndExtension = file.Last();
string nameFile = fileNameAndExtension.Split(".").First();
string extension = fileNameAndExtension.Split(".").Last();

Console.WriteLine($"File name: {nameFile}");
Console.WriteLine($"File extension: {extension}");