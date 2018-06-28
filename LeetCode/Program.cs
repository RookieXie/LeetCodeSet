using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] s = { 1, 2, -1, -2, 2, 1, -2, 1, 4, -5, 4 };

            int[] s1 = { 2 };
            //int v =7;
            //var test = "";
            //var str = "bacda";
            //var need = "pi";
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);
            //MCMXCVI

            var res = new LengthofLastWord().LengthOfLastWord(" ");
            Console.WriteLine(res);
            //new Program().hh();


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

        public async Task<int> GetAsyncInt()
        {
            Console.WriteLine("异步获取数值One");
            Task<int> t = Task.Run(() => { Console.WriteLine("异步获取数值One1111"); return 1; });
            Console.WriteLine("异步获取数值OneTTTTT");
            int res = await t;
  
            return res;
        }
        public async Task<int> GetAsyncIntTwo()
        {
            Console.WriteLine("异步获取数值Two");
            Task<int> t = Task.Run(() => { Console.WriteLine("异步获取数值Two2222"); return 2; });
            return await t;
        }
        public  async void hh()
        {
            int one =await GetAsyncInt();
            
            //Task.WaitAll(new Task[] { one });
            int two =await GetAsyncIntTwo();
            //two.Start();


            Console.WriteLine(one*two);
            

        }
    }
}
