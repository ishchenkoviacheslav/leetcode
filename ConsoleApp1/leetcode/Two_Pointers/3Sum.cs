using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.Two_Pointers
{
    internal class _3Sum
    {
        //public IList<IList<int>> ThreeSum(int[] nums)
        //{
        //    var result = new Dictionary<string, List<int>>();

        //    var onlyUniqe = nums.Distinct().ToHashSet();
        //    //var ordered = nums.OrderBy(x => x).ToList();
        //    HashSet<int> excludingValuesI = new HashSet<int>();
        //    int temp = 0, lookingNumber = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (!excludingValuesI.Contains(nums[i]))
        //        {
        //            excludingValuesI.Add(nums[i]);
        //            for (int j = 0; j < nums.Length; j++)
        //            {
        //                temp = nums[i] + nums[j];
        //                if (temp == 0)
        //                {
        //                    lookingNumber = 0;
        //                }
        //                else if (temp > 0)
        //                {
        //                    lookingNumber = temp * -1;
        //                }
        //                else if (temp < 0)
        //                {
        //                    lookingNumber = Math.Abs(temp);
        //                }
        //                if (onlyUniqe.Contains(lookingNumber))
        //                {
        //                    var orederedValues = new List<int> { nums[i], nums[j], lookingNumber }.OrderBy(x => x).Select(x => x.ToString());
        //                    var orederedKey = string.Join(string.Empty, orederedValues);
        //                    if (!result.ContainsKey(orederedKey))
        //                    {
        //                        result[orederedKey] = new List<int> { nums[i], nums[j], lookingNumber };
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    return result.Values.Cast<IList<int>>().ToList();
        //}

        //public IList<IList<int>> ThreeSum(int[] nums)
        //{
        //    var result = new Dictionary<string, List<int>>();
        //    HashSet<int> excludingValuesI = new HashSet<int>();
        //    for (int i = 0; i < nums.Length - 2; i++)
        //    {
        //        if (!excludingValuesI.Contains(nums[i]))
        //        {
        //            excludingValuesI.Add(nums[i]);
        //            for (int j = i + 1; j < nums.Length - 1; j++)
        //            {
        //                for (int k = j + 1; k < nums.Length; k++)
        //                {
        //                    if (nums[i] + nums[j] + nums[k] == 0)
        //                    {
        //                        var orederedValues = new List<int> { nums[i], nums[j], nums[k] }.OrderBy(x => x).Select(x => x.ToString());
        //                        var orederedKey = string.Join(string.Empty, orederedValues);
        //                        if (!result.ContainsKey(orederedKey))
        //                        {
        //                            result[orederedKey] = new List<int> { nums[i], nums[j], nums[k] };
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    return result.Values.Cast<IList<int>>().ToList();
        //}
    }
}
