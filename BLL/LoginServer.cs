using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class LoginServer
    {
        /// <summary>
        /// 登录是否成功
        /// </summary>
        public static bool GetLogin(string name, string psd)
        {
            string sql = String.Format("select * from users where userName='{0}' and userPsd='{1}'", name, psd);
            LoginHelper loginHelper = new LoginHelper();
            return loginHelper.ExecuteSql(sql);
        }
    }
}
