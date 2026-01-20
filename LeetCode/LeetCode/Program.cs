using LeetCode.Two_Sum;

Solution solution = new Solution();
int[] nums = { 3, 3 };
int target = 6;
int[] sum = solution.TwoSum(nums, target);
Console.WriteLine($"[{sum[0]}, {sum[1]}]");