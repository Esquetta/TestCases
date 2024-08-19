string RemoveEvenLengthWords(string sentence)
{
    string[] words = sentence.Split(' ');
    List<string> resultWords = new List<string>();

    foreach (var item in words)
    {
        if (item.Length % 2 != 0)
        {
            resultWords.Add(item);
        }
    }

    return string.Join(" ", resultWords);
}

Console.WriteLine(RemoveEvenLengthWords("hi Joe how is it going"));