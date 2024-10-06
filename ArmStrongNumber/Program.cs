

bool isArmsStrongNumber(int number)
{
    int numberOfDigits = number.ToString().Length;
    int sum = 0;
    int temp = number;

    // Sayının her bir basamağını hesaplayıp uygun güçte topluyoruz.
    while (temp > 0)
    {
        int digit = temp % 10;
        sum += (int)Math.Pow(digit, numberOfDigits);
        temp /= 10;
    }

    // Toplam sayıya eşit mi kontrolü yapıyoruz.
    return sum == number;
}

Console.WriteLine(isArmsStrongNumber(15));