string OddEvenFib(int num)
{
    if (num == 1)
    {
        return "even";
    }
    else if (num == 2 || num == 3)
    {
        return "odd";
    }

    int a = 0;
    int b = 0;
    int fib = 0;

    for (int i = 4; i <= num; i++)
    {
        fib = a + b;
        a = b;
        b = fib;
    }
    if (fib % 2 == 0)
    {
        return "even";
    }
    else
    {
        return "odd";
    }
}
