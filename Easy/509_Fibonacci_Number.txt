public class Solution {
    int[] mem = new int[31];
    
    public int Fib(int n) {
        Array.Fill(mem, -1);
        mem[0] = 0;
        mem[1] = 1;

        return toFib(n);
    }

    public int toFib(int n) 
    {
        if(mem[n] == -1) {
            mem[n] = toFib(n - 1) + toFib(n - 2);
        }

        return mem[n];
    }
}