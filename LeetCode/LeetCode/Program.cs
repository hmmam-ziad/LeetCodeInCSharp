

using LeetCode.Rotate_Array;

Solution solution = new Solution();
int[] nums = { -1, -100, 3, 99 };
solution.Rotate(nums, 2);
foreach (int num in nums)
{
    Console.Write(num);
    Console.Write(" ");

}
