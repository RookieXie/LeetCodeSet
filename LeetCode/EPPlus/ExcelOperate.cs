﻿using OfficeOpenXml;
using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Text;
using Dapper;
namespace LeetCode.EPPlus
{
    public class ExcelOperate
    {
        public static string Import(string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            using (IDbConnection conn = new MySqlConnection("server=5940b72c83b87.sh.cdb.myqcloud.com;port=11131;uid=root;pwd=iuEKm1vK+Oqd5TQ=;database=pmh;Min Pool Size=0;Pooling=true;connect timeout=120;CharSet=utf8"))
            {
                using (ExcelPackage package = new ExcelPackage(file))
                {
                    string sql = "";
                    StringBuilder sb = new StringBuilder();
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    int rowCount = worksheet.Dimension.Rows;
                    int ColCount = worksheet.Dimension.Columns;
                    bool bHeaderRow = true;
                    for (int row = 1; row <= rowCount; row++)
                    {
                        for (int col = 1; col <= ColCount; col++)
                        {
                            if (bHeaderRow)
                            {
                                sql = "insert into wx_annualmeeting_check(realName)values(@RealName)";
                                conn.Execute(sql, new { RealName = worksheet.Cells[row, col].Value.ToString().Trim() });
                                sb.Append(worksheet.Cells[row, col].Value.ToString() + "\t");
                            }
                            else
                            {
                                sb.Append(worksheet.Cells[row, col].Value.ToString() + "\t");
                            }
                        }
                        sb.Append(Environment.NewLine);
                    }
                    return sb.ToString();
                }
            }
        }
    }
}
