﻿

bool ReverseWord(string text)
{
    text = text.ToLower();
    string reverseText = "";
    for (int i = text.Length - 1; i >= 0; i--)
    {
        reverseText += text[i];
    }


    for (int i = 0; i < text.Length; i++)
    {
        if (reverseText[i] != text[i])
        {
            return false;
            break;
        }
    }
    return true;

}

Console.WriteLine(ReverseWord("Civic"));
