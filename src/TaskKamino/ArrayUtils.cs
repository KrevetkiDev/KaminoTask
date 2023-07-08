namespace TaskKamino;

public static class ArrayUtils
{
    public static (int, int) GetIndexes(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }
                else
                {
                    int first = nums[i];
                    int second = nums[j];
                    var sum = first + second;
                    if (sum == target)
                    {
                        Console.WriteLine(i);
                        Console.WriteLine(j);
                        return (i, j);
                    }
                }
            }
        }

        throw new Exception("Error");
    }
}