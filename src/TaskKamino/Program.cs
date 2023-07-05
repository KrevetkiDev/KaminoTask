var nums = new  List <int> () {2, 7, 11, 15, 9};
int target = 9;
GetIndexes(nums, 9);

(int, int) GetIndexes(List<int> nums, int target)
{
    for (int i = 0; i < nums.Count; i++)
    {
        for (int j = 0; j < nums.Count; j++)
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
                    return (first, second);

                }
            }
        }
    }

    throw new Exception("Error");
}