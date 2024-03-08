namespace ConsoleApp1.leetcode.array_string
{
    internal class MajorityElement
    {
        public int MajorityElement_(int[] nums)
        {
            return nums.GroupBy(n => n).OrderByDescending(g => g.Count()).Select(g => g.Key).First();

        }
    }
}
