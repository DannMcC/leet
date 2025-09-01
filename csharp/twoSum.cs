public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hashMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int currentNum = nums[i];
            int difference = target - currentNum;
            if(hashMap.ContainsKey(difference))
            {
                return new int[] { hashMap[difference], i };
            }
            hashMap[currentNum] = i;
        }
        return Array.Empty<int>();
    }
}