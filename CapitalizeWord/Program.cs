string Capitalize(string str)
{
    // hello world = Hello World
    string[] words = str.Split(" ");

    List<string> resultWords = new List<string>();

    foreach (var item in words)
    {
        string tempStr = char.ToUpper(item[0]) + item.Substring(1);
        resultWords.Add(tempStr);
    }

    return string.Join(" ", resultWords);


}

Console.WriteLine(Capitalize("mahmut tuncer"));