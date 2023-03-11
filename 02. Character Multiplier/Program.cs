string input = Console.ReadLine();

string firstString = input.Split().First();
string secondString = input.Split().Last();

int totalSum = 0;
string watsLeft = string.Empty;

int minLenght = Math.Min(firstString.Length, secondString.Length);

for (int i = 0; i < minLenght; i++)
{
    totalSum += firstString[i] * secondString[i];
}

if (firstString.Length > secondString.Length)
{
    watsLeft = firstString.Substring(secondString.Length);
}
else if (secondString.Length > firstString.Length)
{
    watsLeft = secondString.Substring(firstString.Length);
}

foreach (var ch in watsLeft)
{
    totalSum += ch;
}

Console.WriteLine(totalSum);