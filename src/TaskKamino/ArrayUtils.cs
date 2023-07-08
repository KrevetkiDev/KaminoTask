namespace TaskKamino;

public static class ArrayUtils
{
    public static (int, int) GetIndexes(int[] nums, int target)
    {
        if (nums == null || nums.Length == 0)
        {
            throw new ArgumentException("Array is null or empty", nameof(nums));
        }
        
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
                        
                        return (i, j);
                    }
                }
            }
        }

        throw new ArgumentException("Error: no elements were found whose sum is equal to target");
    }
}