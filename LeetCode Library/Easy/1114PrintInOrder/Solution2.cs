namespace LeetCode_Library.Easy._1114PrintInOrder;

public class Solution2
{
    private static readonly AutoResetEvent FirstDone = new AutoResetEvent(false);
    private static readonly AutoResetEvent SecondDone = new AutoResetEvent(false);

    public Solution2()
    {
    }

    public void First(Action printFirst)
    {
        printFirst();
        FirstDone.Set();
    }

    public void Second(Action printSecond)
    {
        FirstDone.WaitOne();
        printSecond();
        SecondDone.Set();
    }

    public void Third(Action printThird)
    {
        SecondDone.WaitOne();
        printThird();
    }
}