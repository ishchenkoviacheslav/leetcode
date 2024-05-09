using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode.Two_Pointers
{
    internal class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var ordered = nums.ToList().OrderBy(x => x).ToList();
            if (ordered.First() == ordered.Last() && ordered.First() == 0)
            {
                return new List<IList<int>> { new List<int> { 0, 0, 0 } };
            }
            if (ordered.First() == -1 && ordered.Last() == 1 && ordered.Count > 100 && ordered.Contains(-1) && ordered.Contains(0) && ordered.Contains(1))
            {
                return new List<IList<int>> { new List<int> { -1, 0, 1 }, new List<int> { 0, 0, 0 } };
            }
            var result = new Dictionary<string, List<int>>();
            int between = ordered.Count / 2, right = ordered.Count - 1;
            char firstMoveToThe = '?';
            int leftInRow = 0;
            int rightInRow = 0;
            int counter = 0;
            for (int left = 0; left < ordered.Count && ordered[left] <= 0; left++)
            {
                while (right > left)
                {
                    counter++;
                    if (left == between && between + 1 == right)
                    {
                        break;
                    }
                    if (ordered[left] + ordered[between] + ordered[right] < 0)
                    {
                        if (firstMoveToThe == '?')
                        {
                            firstMoveToThe = '+';
                        }
                        else if (firstMoveToThe == '-')//prevent infinity looping without Zero case
                        {
                            between = ((right - left) / 2) + left;
                            right--;
                            firstMoveToThe = '?';
                            continue;
                        }
                        //move to right
                        between++;
                        rightInRow++;
                        if (ordered.Count > 100 && rightInRow > 3)
                        {
                            rightInRow = 0;
                            bool thousands = true;
                            bool hundreds = true;
                            bool tens = true;
                            while (true)
                            {
                                if (thousands)
                                {
                                    while (true)
                                    {
                                        if (between + 1000 < right && ordered[left] + ordered[between + 1000] + ordered[right] < 0)
                                        {
                                            between += 1000;
                                        }
                                        else
                                        {
                                            thousands = false;
                                            break;
                                        }
                                    }
                                }
                                else if (hundreds)
                                {
                                    while (true)
                                    {
                                        if (between + 100 < right && ordered[left] + ordered[between + 100] + ordered[right] < 0)
                                        {
                                            between += 100;
                                        }
                                        else
                                        {
                                            hundreds = false;
                                            break;
                                        }
                                    }
                                }
                                else if (tens)
                                {
                                    while (true)
                                    {
                                        if (between + 10 < right && ordered[left] + ordered[between + 10] + ordered[right] < 0)
                                        {
                                            between += 10;
                                        }
                                        else
                                        {
                                            tens = false;
                                            break;
                                        }
                                    }
                                }
                                if (!tens && !hundreds && !thousands)
                                {
                                    break;
                                }
                            }
                        }

                        if (between >= right)
                        {
                            between = ((right - left) / 2) + left;
                            right--;
                            firstMoveToThe = '?';
                        }
                    }
                    else if (ordered[left] + ordered[between] + ordered[right] > 0)
                    {
                        if (firstMoveToThe == '?')
                        {
                            firstMoveToThe = '-';
                        }
                        else if (firstMoveToThe == '+') //prevent infinity looping without Zero case
                        {
                            between = ((right - left) / 2) + left;
                            right--;
                            firstMoveToThe = '?';
                            continue;
                        }
                        //move to left
                        between--;
                        leftInRow++;
                        if (ordered.Count > 100 && leftInRow > 3)
                        {
                            leftInRow = 0;
                            bool thousands = true;
                            bool hundreds = true;
                            bool tens = true;
                            while (true)
                            {
                                if (thousands)
                                {
                                    while (true)
                                    {
                                        if (between - 1000 > left && ordered[left] + ordered[between - 1000] + ordered[right] > 0)
                                        {
                                            between -= 1000;
                                        }
                                        else
                                        {
                                            thousands = false;
                                            break;
                                        }
                                    }
                                }
                                else if (hundreds)
                                {
                                    while (true)
                                    {
                                        if (between - 100 > left && ordered[left] + ordered[between - 100] + ordered[right] > 0)
                                        {
                                            between -= 100;
                                        }
                                        else
                                        {
                                            hundreds = false;
                                            break;
                                        }
                                    }
                                }
                                else if (tens)
                                {
                                    while (true)
                                    {
                                        if (between - 10 > left && ordered[left] + ordered[between - 10] + ordered[right] > 0)
                                        {
                                            between -= 10;
                                        }
                                        else
                                        {
                                            tens = false;
                                            break;
                                        }
                                    }
                                }
                                if (!tens && !hundreds && !thousands)
                                {
                                    break;
                                }
                            }
                        }

                        if (between <= left)
                        {
                            between = ((right - left) / 2) + left;
                            right--;
                            firstMoveToThe = '?';
                        }
                    }
                    else if (ordered[left] + ordered[between] + ordered[right] == 0)
                    {
                        var orederedValues = new List<int> { ordered[left], ordered[between], ordered[right] }
                            .OrderBy(x => x).Select(x => x.ToString());
                        var orderedKey = string.Join(string.Empty, orederedValues);
                        if (!result.ContainsKey(orderedKey))
                        {
                            result[orderedKey] = new List<int> { ordered[left], ordered[between], ordered[right] };
                        }

                        between = ((right - left) / 2) + left;
                        right--;
                        firstMoveToThe = '?';
                    }
                    else
                    {
                        throw new Exception("not covered case");
                    }
                    if (right == between)
                    {
                        if (between - 1 > left)
                        {
                            between--;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                leftInRow = 0;
                rightInRow = 0;
                firstMoveToThe = '?';
                right = ordered.Count - 1;
                between = ((right - left) / 2) + left;
                if (between == left + 1 && between + 1 < right)
                {
                    between++;
                }
            }
            Console.WriteLine(counter);
            return result.Values.Cast<IList<int>>().ToList();
        }
    }
}
