
string digits = Console.ReadLine();
int multiplicator = int.Parse(Console.ReadLine());

if (multiplicator == 0)
{
    Console.WriteLine(0);
    return;
}

List<int> result = new List<int>();
int remainder = 0;

for (int i = digits.Length - 1; i >= 0; i--)
{
    int lastDigit = digits[i] - '0';
    int multiplication = lastDigit * multiplicator;
    multiplication += remainder;

    result.Insert(0, multiplication % 10);

    remainder = multiplication / 10;
}

if (remainder > 0)
{
    result.Insert(0, remainder);
}

Console.WriteLine(string.Join("", result));

