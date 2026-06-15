

using LeetCode.Merge_Sorted_Array;
Solution solution = new Solution();
int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
int[] nums2 = new int[] { 2, 5, 6 };
solution.Merge(nums1, 3, nums2, 3);

foreach (var num in nums1)
{
    Console.WriteLine(num);
}