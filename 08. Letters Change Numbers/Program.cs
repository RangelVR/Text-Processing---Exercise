string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

double totalSum = 0;

for (int i = 0; i < arr.Length; i++)
{

    string str = arr[i];
    double number = double.Parse(str.Substring(1, str.Length - 2));
    char firstLetter = str.First();
    char lastLetter = str.Last();

    double sum = 0;
    int position = 0;

    if (char.IsUpper(firstLetter))
    {
        position = firstLetter - 64;
        sum += number / position;
    }
    else
    {
        position = firstLetter - 96;
        sum += number * position;
    }

    if (char.IsUpper(lastLetter))
    {
        position = lastLetter - 64;
        sum -= position;
    }
    else
    {
        position = lastLetter - 96;
        sum += position;
    }
    totalSum += sum;
}

Console.WriteLine($"{totalSum:f2}");