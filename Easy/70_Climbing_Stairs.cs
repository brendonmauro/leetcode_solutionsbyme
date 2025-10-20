public class Solution {
    int[] myMem = new int[46];

    public int ClimbStairs(int n) {
        myMem[1] = 1;
        myMem[2] = 2;

        return ToClimb(n);
    }

    public int ToClimb(int n)
    {
        if(myMem[n] > 0)
            return myMem[n];
        else 
        {
            myMem[n] = ToClimb(n -1) + ToClimb(n-2);
            return myMem[n];   
        }
    }
}