/**
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *     public int Get(int index) {}
 *     public int Length() {}
 * }
 */

class Solution {
    public int FindInMountainArray(int target, MountainArray mountainArr) {
        int n = mountainArr.Length();
        int l = 0;
        int r = n - 1;
        int peek = -1;
        int peekN = -1;
        while (l <= r) {
            int mid = (l + r) / 2;
            if (mid == 0) {
                l = 1;
                continue;
            } else if (mid == n - 1) {
                r = n - 2;
                continue;
            }
            int mN = mountainArr.Get(mid);
            int pN = mountainArr.Get(mid-1);
            int bN = mountainArr.Get(mid+1);
            if (mN > pN && mN > bN) {
                peek = mid;
                peekN = mN;
                break;
            } else if (mN > pN) {
                l = mid + 1;
            } else {
                r = mid - 1;
            }
        }
        if (target > peekN) return -1;
        if (target == peekN) return peek;
        int res = binarySearch(0, peek - 1, 1, target, mountainArr);
        if (res != -1) return res;
        return binarySearch(peek + 1, n - 1, -1, target, mountainArr);
    }

    private int binarySearch(int l, int r, int direction, int target, MountainArray mountainArr) {
        while (l <= r) {
            int mid = (l + r) / 2;
            int mN = mountainArr.Get(mid);
            if (target == mN) return mid;
            else if (direction * target < direction * mN) r = mid - 1;
            else l = mid + 1;
        }
        return -1;
    }
}