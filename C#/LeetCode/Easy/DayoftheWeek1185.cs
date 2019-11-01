using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// Given a date, return the corresponding day of the week for that date.
    /// The input is given as three integers representing the day, month and year respectively.
    /// 
    /// Return the answer as one of the following values { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}.
    /// </summary>
    public class DayoftheWeek1185
    {
        /// <summary>
        /// 1.蔡勒Zeller公式  $week = ($d+2*$m+3*($m+1)/5+$y+$y/4-$y/100+$y/400)%7;  0-6 星期日--星期六
        /// 2.基姆拉尔森计算公式 Week=(Day + 2*Month + 3*(Month+1）/5 + Year + Year/4 - Year/100 + Year/400) % 7  0-6 星期1--星期日
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns>2019-10-17</returns>
        public string DayOfTheWeek(int day, int month, int year)
        {
            if (month == 1 || month == 2)
            {
                month = 12 + month;
                year--;
            }
            int week = (day + 2 * month + 3 * (month + 1) / 5 + year + year / 4 - year / 100 + year / 400) % 7;
            string[] weekStr = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };


            return weekStr[week];
        }
    }
}
