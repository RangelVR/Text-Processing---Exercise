using System.Text;

string input = Console.ReadLine();

StringBuilder result = new StringBuilder();

int bombPower = 0;

for (int i = 0; i < input.Length; i++)
{
    char ch = input[i];

    if (ch == '>')
    {
        result.Append(ch);
        int currBombPower = input[i + 1] - '0';
        bombPower += currBombPower;
    }
    else
    {
        if (bombPower > 0)
        {
            bombPower--;
        }
        else
        {
            result.Append(ch);
        }
    }
}

Console.WriteLine(result);