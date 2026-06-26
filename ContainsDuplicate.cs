/* 217.  Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

 

Example 1:

Input: nums = [1,2,3,1]

Output: true

Explanation:

The element 1 occurs at the indices 0 and 3. */


//#region   FIRST APPROACH is Linq 

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        return nums.Length != nums.Distinct().Count() ;
    }
}

 //#region   time complexity is O(n) and space complexity is O(n) as well. but we can do better than this.because average time 
  //#region  complexity of HashSet is O(1) and worst case is O(n). so we can use HashSet to solve this problem. 

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        foreach (int num in nums) {
            if (set.Contains(num)) {
                return true;
            }
            set.Add(num);
        }
        return false;
    }
}


