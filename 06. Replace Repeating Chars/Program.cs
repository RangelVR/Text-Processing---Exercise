
string letters = Console.ReadLine();

for (int i = 0; i < letters.Length; i++)
{
    for (int k = i + 1; k <letters.Length; k++)
    {
        if (letters[i] == letters[k])
        {
            letters = letters.Remove(i, 1);
            k--;
        }
        else
        {
            break;
        }
    }
}

Console.WriteLine(letters);