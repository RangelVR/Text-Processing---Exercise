string input = Console.ReadLine();

string code = string.Empty;

foreach (var ch in input)
{
    code += (char)(ch + 3);
}

Console.WriteLine(code);

//--------------------------------------------------------
//using System.Text;

//string input = Console.ReadLine();

//StringBuilder sb = new StringBuilder();

//foreach (var ch in input)
//{
//    sb.Append((char)(ch + 3));
//}

//Console.WriteLine(sb.ToString());