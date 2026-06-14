

using LeetCode.Pascals_Traiangle;
Solution solution = new Solution();
IList<IList<int>> triangle = solution.Generate(5);

foreach (var row in triangle)
{
    Console.WriteLine(string.Join(", ", row));
}