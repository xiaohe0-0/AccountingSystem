using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
    public class ManagerHelper
    {
        //数据库连接
        private string connStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DB\AccountSys.mdf;Integrated Security=True;User Instance=True";

        /// <summary>
        /// 得到数据
        /// </summary>
        public DataSet GetDataSet(string sql)
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
                adapter.Fill(ds);
                return ds;
            }
        }
        
        /// <summary>
        /// 是否执行成功
        /// </summary>
        public bool ExecuteSql(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand commSel = new SqlCommand();
                commSel.Connection = conn;
                commSel.CommandText = sql;

                int result = commSel.ExecuteNonQuery();
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
