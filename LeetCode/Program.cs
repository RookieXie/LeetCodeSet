using LeetCode.Md5;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = DateTime.Now.ToString("yyyy-MM-dd");
            Console.WriteLine(res);
            //string content = "，";
            //string filePath = "F:\\github\\LeetCodeSet\\LeetCode\\123.xlsx";
            ////content = ExcelOperate.Import(filePath);
            ////Console.WriteLine(content);
            //var now = DateTime.Now;
            //var limitTime = Convert.ToDateTime("2019-01-18");
            //if (now < limitTime)
            //{
            //    Console.WriteLine("baoming");
            //}
            //else
            //{
            //    Console.WriteLine("wufa");
            //}
            //var response= GooglePayHelper.GetReFreshToken();
            // Console.WriteLine(response.Result);
            //var connStr = "server=182.254.128.241;port=4332;uid=root;pwd=XiuQuAPP@2016_DB;database=show_interest;Min Pool Size=0;Pooling=true;connect timeout=120;CharSet=utf8";
            //string publicKey = "3fEh5Dn7Nmo=";

            //Decryptor dec = new Decryptor(EncryptionAlgorithm.TripleDes);
            //dec.InitVec = Convert.FromBase64String(initVector);
            //byte[] plain = dec.Decrypt(Convert.FromBase64String(connStr), Encoding.ASCII.GetBytes(publicKey));
            //var md5Str=MD5Helper.GetMd5("391399258").Substring(4, 8);
            //Console.WriteLine(md5Str);
            //var token = GooglePayHelper.GetProducts();
            //var token = GooglePayHelper.GetReFreshToken();
            //var token = GooglePayHelper.GetProducts();
            //Console.WriteLine(token.Result);
            //new Program().hh();
            //if (Regex.Match(content, "^\\d+$").Success)
            //{
            //    Console.WriteLine("纯数字");
            //}
            //else if (Regex.Match(content, "^[a-zA-Z]+$").Success)
            //{
            //    Console.WriteLine("纯字母");
            //}
            //else if (Regex.Match(content, "^[，。？！：、.@；（）《》~.:'%&·#\"]+$").Success)
            //{
            //    Console.WriteLine("纯符号");
            //}
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
        public async void hh()
        {
            int one = await GetAsyncInt();

            //Task.WaitAll(new Task[] { one });
            int two = await GetAsyncIntTwo();
            //two.Start();


            Console.WriteLine(one * two);


        }
    }
}
