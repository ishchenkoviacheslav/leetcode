using System.Collections;

class Program
{
    static public int[] ProductExceptSelf(int[] nums)
    {
        int[] answer = new int[nums.Length];
        int temp = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (j == i)
                {
                    continue;
                }
                if(temp == 0)
                {
                    int tempIndex = j + 1 == i ? j + 2 : j + 1;
                    temp = nums[j] * nums[tempIndex];
                    if (tempIndex == j + 2)
                    {
                        j += 2;
                    }
                    else
                    {
                        j++;
                    }
                }
                else
                {
                    temp = temp * nums[j];
                }
            }
            answer[i] = temp;
            temp = 0;
        }

        return answer;
    }
    static void Main()
    {
        var res = ProductExceptSelf(new int[] { 1, 2, 3, 4 });
        //var res = ProductExceptSelf(new int[] { -1, 1, 0, -3, 3 });
    }
}