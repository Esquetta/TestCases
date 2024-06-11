

void FindSecondBiggestNumber(int[] nums)
{

    int Biggest = 0;

    int SecondBig = 0;
    int[] numbers = new int[nums.Length - 1];

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > Biggest)
        {
            Biggest = nums[i];
        }


    }

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != Biggest)
        {
            numbers[i] = nums[i];
        }


    }
    for (int i = 0; i < nums.Length; i++)
    {
        if (numbers[i] > SecondBig)
        {

            SecondBig = numbers[i];
        }


    }

    Console.WriteLine(SecondBig);


}

int[] ints = new int[] { 200, 30, 120, 180, 60, 169, 55, 3, 100, 1, 220, 89, 46, 99, 10 };

FindSecondBiggestNumber(ints);
static void FindSecondBig(int[] nums)
{

    int largest = int.MinValue;
    int second = int.MinValue;
    foreach (int i in nums)
    {
        if (i > largest)
        {
            second = largest;
            largest = i;
        }
        else if (i > second)
            second = i;
    }

    System.Console.WriteLine(second);
}