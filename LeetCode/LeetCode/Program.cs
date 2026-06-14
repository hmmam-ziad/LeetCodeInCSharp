

using LeetCode.Intersection_of_Two_Arrays_II;
Solution solution = new Solution();
var result = solution.Intersect(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });

foreach (var num in result)
{
    Console.WriteLine(string.Join(", ", num));
}