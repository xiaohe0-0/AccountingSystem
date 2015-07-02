using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
    public class LoginHelper
    {
        //数据库连接
        //private string connStr = @"Data Source=WIN2K3;Initial Catalog=AccountSys;User ID=sa;Password=123456";
        private string connStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DB\AccountSys.mdf;Integrated Security=True;User Instance=True";
        
        /// <summary>
        /// 查询数据是否存在
        /// </summary>
        public bool ExecuteSql(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand commSel = new SqlCommand();
                commSel.Connection = conn;
                commSel.CommandText = sql;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = commSel;
                DataSet ds = new DataSet();

                int result = adapter.Fill(ds);
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
