namespace LeetCode_Library.Easy._1114PrintInOrder;

public class Solution1
{
    private static int _cnt = 0;

    public Solution1()
    {
    }

    public void First(Action printFirst)
    {
        printFirst();
        _cnt = 1;
    }

    public void Second(Action printSecond)
    {
        while (_cnt != 1)
        {
        }

        printSecond();
        _cnt = 2;
    }

    public void Third(Action printThird)
    {
        while (_cnt != 2)
        {
        }

        printThird();
        _cnt = 3;
    }
}