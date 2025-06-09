public class GuessGame
{
    protected int guess(int num)
    {
        int pick = 6;
        if (num == pick) return 0;
        else if (num > pick) return -1;
        else return 1;
    }
}

public class Solution : GuessGame
{
    public int GuessNumber(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            int result = guess(i);

            if (result == 0)
            {
                return i;
            }
        }
        return -1;
    }
}
