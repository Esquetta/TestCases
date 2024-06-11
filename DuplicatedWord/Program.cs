string DuplicatedWord(string word)
{
    return new string(word.GroupBy(c => c).Where(g => g.Count() > 1).Select(g => g.Key).ToArray());
}


//Console.WriteLine(DuplicatedWord("happy"));
Console.WriteLine(DuplicatedWord("Controller"));