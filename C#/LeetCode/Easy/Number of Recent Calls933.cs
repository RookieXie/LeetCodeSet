using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /**
     * Write a class RecentCounter to count recent requests.

        It has only one method: ping(int t), where t represents some time in milliseconds.

        Return the number of pings that have been made from 3000 milliseconds ago until now.

        Any ping with time in [t - 3000, t] will count, including the current ping.

        It is guaranteed that every call to ping uses a strictly larger value of t than before.

 

        Example 1:

        Input: inputs = ["RecentCounter","ping","ping","ping","ping"], inputs = [[],[1],[100],[3001],[3002]]
        Output: [null,1,2,3,3]
 

        Note:

        Each test case will have at most 10000 calls to ping.
        Each test case will call ping with strictly increasing values of t.
        Each call to ping will have 1 <= t <= 10^9.
     * **/
    //Number_of_Recent_Calls933
    public class RecentCounter2
    {
        //思路： 记录每次的time,这次的与前几次合并 然后比范围比对
        int[] time;
        int? [] res;
        int kt = 1;
        public RecentCounter2()
        {
            time = new int[10000];
            res = new int?[10001];
            res[0] = null;
        }

        public int Ping(int t)
        {
            int k = 0;
            int min = t - 3000;
            time[kt-1] = t;
            for (int i = 0; i < time.Length; i++)
            {
                if(time[i]>=min && time[i] <= t)
                {
                    k++;
                }
            }
            res[kt] = k;
            kt++;
            return k;
        }
        /**
         * Your RecentCounter object will be instantiated and called as such:
         * RecentCounter obj = new RecentCounter();
         * int param_1 = obj.Ping(t);
         */
    }

    public class RecentCounter
    {
        //思路： 记录每次的time,这次的与前几次合并 然后比范围比对
        Queue<int> list;
        public RecentCounter()
        {
            list = new Queue<int>();
        }

        public int Ping(int t)
        {
            if (list.Count > 0 && list.Peek() < t - 3000) list.Dequeue();
            list.Enqueue(t);
            return list.Count;
        }
        /**
         * Your RecentCounter object will be instantiated and called as such:
         * RecentCounter obj = new RecentCounter();
         * int param_1 = obj.Ping(t);
         */
    }
}
