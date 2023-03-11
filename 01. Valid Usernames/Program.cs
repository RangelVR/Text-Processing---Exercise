string[] passwords = Console.ReadLine().Split(", ");

foreach (var pass in passwords)
{
        bool isValid = true;

	if (pass.Length >= 3 && pass.Length <= 16 )
	{
		foreach (var ch in pass)
		{
		    if (!char.IsLetterOrDigit(ch)  && ch != '_' && ch != '-') //if (!(char.IsLetterOrDigit(item) || item == '_' || item == '-'))
		    {
			isValid = false;
			break;
		    }
		}

		if (isValid)
		{
		    Console.WriteLine(pass);
		}
	}
}
