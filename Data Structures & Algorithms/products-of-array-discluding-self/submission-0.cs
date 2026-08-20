public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] leftProducts = new int[n];   // Product of all before i
        int[] rightProducts = new int[n];  // Product of all after i
        int[] result = new int[n];
        
        // Build left products: [1, 1, 2, 6]
        leftProducts[0] = 1;
        for(int i = 1; i < n; i++) {
            leftProducts[i] = leftProducts[i-1] * nums[i-1];
        }
        
        // Build right products: [24, 12, 4, 1]
        rightProducts[n-1] = 1;
        for(int i = n-2; i >= 0; i--) {
            rightProducts[i] = rightProducts[i+1] * nums[i+1];
        }
        
        // Multiply them: result[i] = left[i] * right[i]
        for(int i = 0; i < n; i++) {
            result[i] = leftProducts[i] * rightProducts[i];
        }
        
        return result;
    }
}