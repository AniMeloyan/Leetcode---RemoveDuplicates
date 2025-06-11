using System;
public class Solution {
    public int RemoveDuplicates(int[] nums){
        if(nums.Length == 0) return 0;
        int k = 1;
        for(int i = 1; i < nums.Length; i ++) {
            if(nums[i] != nums[k-1]) {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}
class Program {
    static void Main(){
        Solution sol = new Solution();
        int[] nums = {1, 1, 2, 2, 3, 4, 4};
        int k = sol.RemoveDuplicates(nums);
        Console.WriteLine("k = " + k);
    
}
}