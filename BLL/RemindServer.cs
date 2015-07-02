using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class RemindServer
    {
        //得到所有事物提醒
        public static DataTable GetALLRemind()
        {
            string sql = string.Format(@"select * from remindSth order by remindDate DESC");
            ManagerHelper mngHelper = new ManagerHelper();
            return mngHelper.GetDataSet(sql).Tables[0];
        }

        //增加事务提醒
        public static bool AddRemind(string remindDate,string remindCon)
        {
            string sql = String.Format(@"insert into remindSth(remindDate,remindCon) values('{0}','{1}')", remindDate,remindCon);
            ManagerHelper mHelper = new ManagerHelper();
            return mHelper.ExecuteSql(sql);
        }

        //修改事务提醒
        public static bool UPRemind(string remindDate, string remindCon,int remindID)
        {
            string sql = String.Format(@"update remindSth set remindDate='{0}',remindCon='{1}' where remindID={2}", remindDate, remindCon, remindID);
            ManagerHelper mHelper = new ManagerHelper();
            return mHelper.ExecuteSql(sql);
        }

        //删除事务提醒
        public static bool DelRemind(int remindID)
        {
            string sql = String.Format(@"delete remindSth where remindID={0}",remindID);
            ManagerHelper mHelper = new ManagerHelper();
            return mHelper.ExecuteSql(sql);
        }
        //存在某天的事务提醒
        public static DataTable ExistRemind(string remindDate)
        {
            string sql = String.Format(@"select * from remindSth where remindDate='{0}'", remindDate);
            ManagerHelper mngHelper = new ManagerHelper();
            return mngHelper.GetDataSet(sql).Tables[0];
        }
    }
}
