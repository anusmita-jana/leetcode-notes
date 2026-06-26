# 1. Problem Summery
# Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

# Brute Force

# Check every pair.

# Time: O(n²)
# Space: O(1)
## Optimized Solution

# Optimized Use Dictionary.

# Time: O(n)
# Space: O(n)

# Solution

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numMap = new Dictionary<int, int>();

        for(int i =0; i< nums.Length; i++){
            int required = target - nums[i];
            if(numMap.ContainsKey(required)){
                return new int[]{numMap[required],i };
            }
            if(! numMap.ContainsKey(nums[i])){
                numMap.Add(nums[i], i);
            }
        }
        return new int[0];
    }
}
