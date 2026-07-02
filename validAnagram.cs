/* 242. problem Summary
 Given two strings s and t, return true if t is an anagram of s, and false otherwise.

 
Solution approach:

Length Check: First, we check if s.Length != t.Length. If they aren't the same length, they can't possibly be anagrams, so we return false immediately.

Populating the Dictionary: We loop through the first string (s). For each character, we either add it to the dictionary with a count of 1 or increment its existing count.

Validating with the Second String: We loop through the second string (t). For each character:

If the character is not in our dictionary, or if its count has already dropped to 0, it means t has an extra or unexpected character. We return false.

Otherwise, we decrement that character's count by 1.
If the loop finishes without hitting a failure condition, it means every character in t perfectly matched and neutralized the character counts from s. We return true.

time complexity:  O(n);
space complexity: O(k);  where k=26


solution: */

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        Dictionary<char,int> counts= new Dictionary<char,int>();

        foreach(char c in s){
            if(counts.ContainsKey(c)){
                counts[c]++;
            }
            else{
                counts[c]=1;
            }

        }

        foreach(char c in t){
            if(!counts.ContainsKey(c) || counts[c]==0){
                return false;
            }
            else{
                counts[c]--;
            }
        }
        return true;
    }
}

