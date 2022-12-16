# Permutation in String
| Category | Difficulty | Likes | Dislikes
| -------- | ---------- | ----- | --------
algorithms | Medium (43.61%) | 7725 | 258

## Tags
- two-pointers 
- sliding-window

## Companies
- microsoft

# Problem
Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.
In other words, return true if one of s1's permutations is the substring of s2.

## Example 1:
- Input: s1 = "ab", s2 = "eidbaooo"
- Output: true
- Explanation: s2 contains one permutation of s1 ("ba").
## Example 2:
- Input: s1 = "ab", s2 = "eidboaoo"
- Output: false

## Constraints:
- 1 <= s1.length, s2.length <= 104
- s1 and s2 consist of lowercase English letters.

# Tests
## Case 1
Input s1 = "ab", s2 = "eidbaooo"
Output true

## Case 2
Input s1 = "ab", s2 = "eidboaoo"
Output false

# Stats
- Runtime 82 ms
	- Beats 92.77%
- Memory 40.2 MB
	- Beats 11.4%