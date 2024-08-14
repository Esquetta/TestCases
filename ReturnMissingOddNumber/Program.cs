

int ReturnMissingOddNumber(int[] nums)
{
	var sortedArray = nums.OrderDescending().ToArray();
	for (int i = 0; i < sortedArray.Length-1; i++)
	{
		if (Math.Abs((sortedArray[i] - sortedArray[i + 1])) != 2)
		{
			return sortedArray[i] - 2;
		}
	}

	return 0;

}


Console.WriteLine(ReturnMissingOddNumber(new int[] {1,3,5,7,9,13,15,17}));


