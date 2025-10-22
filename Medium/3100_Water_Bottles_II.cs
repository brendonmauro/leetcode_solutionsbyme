public class Solution {
    public int MaxBottlesDrunk(int numBottles, int numExchange) {
        int bottlesDrunk = 0;
        int emptyBottles = 0;
        while(numBottles > 0 || emptyBottles >= numExchange){
            if(emptyBottles < numExchange){
                bottlesDrunk += numBottles;
                emptyBottles += numBottles;
                numBottles = 0;
            } else {
                numBottles++;
                emptyBottles-= numExchange;
                numExchange++; 
            }
        }

        return bottlesDrunk;
    }
}