int[] DoubleNumber(int[] arr, int num)
{
    //doubleNumber([1,2,3,2,1], 2) should return [1,4,3,4,1]

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == 2)
        {
            arr[i] *= 2;
        }
    }

    return arr;
}


Console.WriteLine(DoubleNumber(new int[] { 1, 2, 3, 2, 1 }, 2));