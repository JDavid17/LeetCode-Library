namespace LeetCode_Library.Easy._724FindPivotindex;

public class Solution724
{
    // Solution 1
    /// <summary>
    /// Results: Runtime Exceeded
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int PivotIndex(int[] nums)
    {
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            var leftSum = nums.Take(i).Sum();
            var rightSum = i == nums.Length - 1 ? 0 : nums.Skip(i + 1).Sum();

            if (leftSum == rightSum)
                return i;
        }

        return -1;
    }

    // Solution 2
    /// <summary>
    /// Results: Accepted
    /// Runtime: 97ms Beats 77.48%
    /// Memory: 49MB Beats 5.15%
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int PivotIndexSolution2(int[] nums)
    {
        var leftSum = 0;
        var rightSum = 0;

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (i == 0)
            {
                leftSum = nums.Take(i).Sum();
                rightSum = nums.Skip(i + 1).Sum();
            }
            else
            {
                leftSum += nums[i - 1];
                rightSum -= nums[i];
            }

            if (leftSum == rightSum)
                return i;
        }

        return -1;
    }
    
    // Solution 3
    /// <summary>
    /// Results: Accepted
    /// Runtime: 93ms Beats 89.5%
    /// Memory: 48.5MB Beats 15.08%
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int PivotIndexSolution3(int[] nums)
    {
        int totalSum = nums.Sum();

        int leftSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (leftSum == totalSum - leftSum - nums[i])
                return i;
            leftSum += nums[i];
        }

        return -1;
    }
}