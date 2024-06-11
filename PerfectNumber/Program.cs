
bool PerfectNumber(int number)
{
    int total = 0;

    for (int i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            total += i;
        }
    }

    if (total != number)
        return false;

    return true;

}
Console.WriteLine(PerfectNumber(56));