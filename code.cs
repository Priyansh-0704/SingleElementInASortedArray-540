public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int start = 0, end = nums.Length - 1;
        while(start <= end)
        {
            int mid = start + (end - start) / 2;

            if(mid == 0 || mid == nums.Length - 1)
            {
                // if mid is at any of the extreme points then return mid
                return nums[mid];
            }
            if(nums[mid] != nums[mid + 1] && nums[mid] != nums[mid - 1])
            {
                // nums[mid] is the unique element
                return nums[mid];
            }
            if(mid % 2 == 0)
            {
                // mid is even index
                if(nums[mid] == nums[mid + 1])
                {
                    // unique element lies in the right half
                    start = mid + 1;
                } else
                {
                    // unique element lies in the left half
                    end = mid - 1;
                }
            } else
            {
                // mid is odd index
                if(nums[mid] == nums[mid + 1])
                {
                    // unique element lies in the left half
                    end = mid - 1;
                } else
                {
                    // unique element lies in the right half
                    start = mid + 1;
                }
            }
        }
        return -1;
    }
}

// The idea used here is using the index of the elements to find out whether the unique element is in prefix or in suffix
