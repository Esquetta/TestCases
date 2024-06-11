

void FindOddNumber(int[] array)
{
    int Spacing = array[0] - array[1];

    int[] asc = new int[array.Length + 1];
    int[] desc = new int[array.Length + 1];
    if (Spacing < 0)
    {
        asc[0] = array[0];
        //asc
        for (int i = 1; i < array.Length; i++)
        {
            asc[i] = asc[i - 1] + (Spacing * -1);
        }

        for (int i = 0; i < asc.Length; i++)
        {
            if (asc[i] != array[i])
            {
                Console.WriteLine(asc[i]);
            }
        }
    }
    else
    {
        //desc
        desc[0] = array[0];
        //asc
        for (int i = 1; i < array.Length; i++)
        {
            desc[i] = desc[i - 1] - Spacing;
        }



        for (int i = 0; i < desc.Length; i++)
        {
            if (desc[i] != array[i])
            {
                Console.WriteLine(desc[i]);
            }
        }
    }


}
int[] array = new int[] { 1, 3, 5, 7, 11 };
FindOddNumber(array);
