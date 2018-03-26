using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] s = {1,3};

            int[] s1 = { 2 };
            int v =7;
            var str = "aaabaaaa";
            var need = "pi";
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);
            //MCMXCVI
            
            var res = new LongestPalindromicSubstring().LongestPalindrome(str);
            Console.WriteLine(res);


            Console.ReadKey();
        }
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<List<int>> res = new List<List<int>>();
            Array.Sort(nums);
            int length = nums.Length;
            for (int i = 0; i < length - 2; i++)
            {

                if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
                {
                    int lo = i + 1, hi = length - 1, sum = 0 - nums[i];
                    while (lo < hi)
                    {
                        if (nums[lo] + nums[hi] == sum)
                        {
                            res.Add(new List<int> { nums[i], nums[lo], nums[hi] });
                            while (lo < hi && nums[lo] == nums[lo + 1]) lo++;
                            while (lo < hi && nums[hi] == nums[hi - 1]) hi--;
                            lo++; hi--;
                        }
                        else if (nums[lo] + nums[hi] < sum) lo++;
                        else hi--;
                    }
                }
            }
            return res.ToArray();
        }
    }
}
