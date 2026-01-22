
using LeetCode.Valid_Mountain_Array;

Solution solution = new Solution();
int[] arr = { 0, 3, 2, 1 };
if (solution.ValidMountainArray(arr))
    Console.WriteLine("Its a mountain array");
else
    Console.WriteLine("Its not a mountain array");