using TaskKamino;

namespace TaskKaminoTests;

public class ProgramTests
{
    [Theory()]
    [InlineData(new int[] { 3, 2, 4 }, 6)]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9)]
    [InlineData(new int[] { 3, 3 }, 6)]
    public void Test(int[] nums, int expectedTarget)
    {
        //act
        var result = ArrayUtils.GetIndexes(nums, expectedTarget);
        int target = nums[result.Item1] + nums[result.Item2];
        // assert
        Assert.Equal(expectedTarget, target);
    }

    [Fact()]
    public void GetIndexes_ShouldThrowArgumentException_WhenArrayIsNull()
    {
        //arrange
        
        int[] nums = null;
        int target = 1;

     //act

        var exception = Assert.Throws<ArgumentException>(() => ArrayUtils.GetIndexes(nums, target));

     //asser
     
       Assert.Equal("Array is null or empty (Parameter 'nums')", exception.Message);
    }

    
    [Fact]
    public void GetIndexes_ShouldThrowArgumentException_WhenArrayIsEmphty()
    {
        //arrange
        int[] array = new int[] {};
        int target = 1;

       //act
       
       var exception = Assert.Throws<ArgumentException>(() => ArrayUtils.GetIndexes(array, target));

       //asser
       Assert.Equal("Array is null or empty (Parameter 'nums')", exception.Message);
    }


    [Fact]

    public void GetIndexes_ShouldThrowArgumentException_WhenElementsNotFound()
    {
        //arrange
        int[] nums2 = new int[] { 6, 2, 3, 5 };
        int target = 1;
        
        //act
        var exception = Assert.Throws<ArgumentException>(() => ArrayUtils.GetIndexes(nums2, target));
        
        //asser
        Assert.Equal("no elements were found whose sum is equal to target (Parameter 'nums')", exception.Message);
    }
}