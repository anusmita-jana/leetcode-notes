/*Problem Summary: 49. Group Anagrams:  
Given an array of strings strs, group the anagrams together. You can return the answer in any order.

 Example 1:
Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

Explanation:
There is no string in strs that can be rearranged to form "bat".
The strings "nat" and "tan" are anagrams as they can be rearranged to form each other.
The strings "ate", "eat", and "tea" are anagrams as they can be rearranged to form each other. 8? */

/* time complexity = o(nk).  n = no. of strings,  k= average string length */

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary < string, List<string>> map = new Dictionary <string,List<string>> ();

        foreach( string ana in strs)
        {
            char[] charArray = ana.ToCharArray();
            Array.Sort(charArray);
            string sortedKey = new string (charArray);

            if(!map.ContainsKey(sortedKey)){
                map[sortedKey] = new List<string>();
            }
            map[sortedKey].Add(ana);

        }
        return map.Values.Cast<IList<string>>().ToList();
    }
}