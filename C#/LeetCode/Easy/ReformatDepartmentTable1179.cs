using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    /**
     * Table: Department

        +---------------+---------+
        | Column Name   | Type    |
        +---------------+---------+
        | id            | int     |
        | revenue       | int     |
        | month         | varchar |
        +---------------+---------+
        (id, month) is the primary key of this table.
        The table has information about the revenue of each department per month.
        The month has values in ["Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"].
 

        Write an SQL query to reformat the table such that there is a department id column and a revenue column for each month.

        The query result format is in the following example:

        Department table:
        +------+---------+-------+
        | id   | revenue | month |
        +------+---------+-------+
        | 1    | 8000    | Jan   |
        | 2    | 9000    | Jan   |
        | 3    | 10000   | Feb   |
        | 1    | 7000    | Feb   |
        | 1    | 6000    | Mar   |
        +------+---------+-------+

        Result table:
        +------+-------------+-------------+-------------+-----+-------------+
        | id   | Jan_Revenue | Feb_Revenue | Mar_Revenue | ... | Dec_Revenue |
        +------+-------------+-------------+-------------+-----+-------------+
        | 1    | 8000        | 7000        | 6000        | ... | null        |
        | 2    | 9000        | null        | null        | ... | null        |
        | 3    | null        | 10000       | null        | ... | null        |
        +------+-------------+-------------+-------------+-----+-------------+

        Note that the result table has 13 columns (1 for the department id + 12 for the months).
     * **/
    public class ReformatDepartmentTable1179
    {
        public string sql = $@"select id,max(case when month = 'Jan' then revenue end) Jan_Revenue,
max(case when month = 'Feb' then revenue end) Feb_Revenue,
max(case when month = 'Mar' then revenue end) Mar_Revenue,
max(case when month = 'Apr' then revenue end) Apr_Revenue,
max(case when month = 'May' then revenue end) May_Revenue,
max(case when month = 'Jun' then revenue end) Jun_Revenue,
max(case when month = 'Jul' then revenue end) Jul_Revenue,
max(case when month = 'Aug' then revenue end) Aug_Revenue,
max(case when month = 'Sep' then revenue end) Sep_Revenue,
max(case when month = 'Oct' then revenue end) Oct_Revenue,
max(case when month = 'Nov' then revenue end) Nov_Revenue,
max(case when month = 'Dec' then revenue end) Dec_Revenue from Department group by id";
    }
}
