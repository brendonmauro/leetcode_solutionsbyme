public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        var it = numBottles;
        int tot = numBottles;
        do{
            (var di,var res) = divide(it, numExchange);
            tot += di;
            it = di + res;
        }
        while(it > 0);

        return tot;
    }

    public (int,int) divide(int numBottles, int numExchange){
        int di = numBottles / numExchange;

        if(di == 0) return (0,0);

        int res = numBottles % numExchange;;
        return (di , res);
    }
}