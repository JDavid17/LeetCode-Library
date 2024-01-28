using System.Globalization;

namespace LeetCode_Library.Easy._728SelfDivingNumber;

public class Solution728
{
    // Solution 1
    /// <summary>
    /// Results: Accepted
    /// Runtime: 78ms Beats 63.92%
    /// Memory: 41.60 MB Beats 17.53%
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        var result = new List<int>();

        for (int i = left; i <= right; i++)
        {
            if (IsNumberSelfDiving(i))
                result.Add(i);
        }
        
        return result;
    }

    public bool IsNumberSelfDiving(int number)
    {
        var numberString = number.ToString();

        if (numberString.Contains("0"))
            return false;

        for (int i = 0; i <= numberString.Length - 1; i++)
        {
            Int32.TryParse(numberString[i].ToString(), out int temp);
            if (temp != 0 && number % temp != 0)
                return false;
        }

        return true;
    }
}