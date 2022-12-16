# Longest Subarray of 1’s After Deleting One Element
| Category | Difficulty | Likes | Dislikes
| -------- | ---------- | ----- | --------
| algorithms | Medium (60.18%) | 1244 | 26

## Tags
- Unknown

## Companies
- Unknown

# Problem
Given a binary array nums, you should delete one element from it.

Return the size of the longest non-empty subarray containing only 1's in the resulting array. Return 0 if there is no such subarray.

## Example 1:
- Input: nums = [1,1,0,1]
- Output: 3
- Explanation: After deleting the number in position 2, [1,1,1] contains 3 numbers with value of 1's.

## Example 2:
- Input: nums = [0,1,1,1,0,1,1,0,1]
- Output: 5
- Explanation: After deleting the number in position 4, [0,1,1,1,1,1,0,1] longest subarray with value of 1's is [1,1,1,1,1].

## Example 3:
- Input: nums = [1,1,1]
- Output: 2
- Explanation: You must delete one element.

## Constraints:
- 1 <= nums.length <= 105
- nums[i] is either 0 or 1.

# Tests
## Case 1
- Input nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2
- Output 6
- Expected 6

## Case 2
- Input nums = [0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1], k = 3
- Output 10
- Expected 10

# Stats
- Runtime 164 ms
	- Beats 89.66%
- Memory 51.6 MB
	- Beats 21.98%