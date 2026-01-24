using LeetCode.Move_Zeroes;

Solution solution = new Solution();
int[] nums = { 0, 1, 0, 3, 12 };
solution.MoveZeroes(nums);

foreach (int x in nums)
{
    Console.Write($"{x}, ");
}