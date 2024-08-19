string SwapCase(string word)
{
    //cOdİNg ıS So FUNn = CoDinG Is sO funN

    char[] words = word.ToCharArray();


    for (int i = 0; i < word.Length; i++)
    {
        if (char.IsUpper(word[i]))
        {
            words[i] = char.ToLower(word[i]);
        }
        else if (char.IsLower(word[i]))
        {
            words[i] = char.ToUpper(word[i]);
        }
    }

    return new string(words);


}

Console.WriteLine(SwapCase("cOdİNg ıS So FUNn"));
