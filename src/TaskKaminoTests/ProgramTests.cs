using TaskKamino;

namespace TaskKaminoTests;

public class ProgramTests
{
    [Theory()]
    [InlineData(new int[] { 3, 2, 4 }, 6)]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9)]
    [InlineData(new int[] { 3, 3 }, 6)]
    public void GetIndexesTest(int[] nums, int target)
    {
        //act
        var result = ArrayUtils.GetIndexes(nums, target);

        //assert
    }
}