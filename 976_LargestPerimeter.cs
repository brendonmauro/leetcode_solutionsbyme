public class Solution {
    public int LargestPerimeter(int[] nums) {
        int largest = 0;
        
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 2; i++)
        {
            if(nums[i] + nums[i+1] > nums[i+2])
            {
                int sum = nums[i] + nums[i+1] + nums[i+2];
                if (sum > largest)
                    largest = sum;
            }
        }

        return largest;
    }

}
