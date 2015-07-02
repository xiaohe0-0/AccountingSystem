using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class UserServer
    {
        /// <summary>
        /// 更改账户名称
        /// </summary>
        public static bool UPUserName(string oriName,string upName){
            string sql = String.Format("update users set userName='{0}' where userName='{1}'",upName,oriName);
            ManagerHelper mHelper = new ManagerHelper();
            return mHelper.ExecuteSql(sql);
        }

        /// <summary>
        /// 更改账户密码
        /// </summary>
        public static bool UPUserPsd(string userName, string userPsd)
        {
            string sql = String.Format("update users set userPsd='{0}' where userName='{1}'", userPsd, userName);
            ManagerHelper mHelper = new ManagerHelper();
            return mHelper.ExecuteSql(sql);
        }
    }
}
