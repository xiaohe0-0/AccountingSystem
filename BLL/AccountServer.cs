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
    public class AccountServer
    {
        //得到账户信息
        public static DataTable GetUserInfo(string userName)
        {
            string sql = string.Format(@"select * from users where userName='{0}'",userName);
            ManagerHelper mngHelper = new ManagerHelper();
            return mngHelper.GetDataSet(sql).Tables[0];
        }
        //得到所有账目
        public static DataTable GetALLAccount()
        {
            string sql = string.Format(@"select accID ID,accDate 日期,classAccInOut 收支,accNum 数目,classAccName 分类,accCon 备注 
                                        from account inner join classAcc on account.classAccID=classAcc.classAccID 
                                        order by accDate DESC, accID DESC");
            ManagerHelper mngHelper = new ManagerHelper();
            return mngHelper.GetDataSet(sql).Tables[0];
        }
        //得到某一账目
        public static DataTable GetCertainAccount(int accID)
        {
            string sql = string.Format(@"select accDate,classAccInOut,accNum,classAccName,accCon 
                                        from account inner join classAcc on account.classAccID=classAcc.classAccID 
                                        where accID={0}",accID);
            ManagerHelper mngHelper = new ManagerHelper();
            return mngHelper.GetDataSet(sql).Tables[0];
        }
        //得到某段时间某一分类的账目
        public static DataTable GetCertainClassAccount(int classAccID, string timeStart, string timeEnd)
        {
            string sql = string.Format(@"select * from account where classAccID={0} and accDate between '{1}' and '{2}'", classAccID, timeStart, timeEnd);
            ManagerHelper mngHelper = new ManagerHelper();
            return mngHelper.GetDataSet(sql).Tables[0];
        }

        //得到某段时间的账目
        public static DataTable GetPeriodAccount(string timeStart,string timeEnd)
        {
            string sql = string.Format(@"select accID ID,accDate 日期,classAccInOut 收支,accNum 数目,classAccName 分类,accCon 备注 
                                        from account inner join classAcc on account.classAccID=classAcc.classAccID 
                                        where accDate between '{0}' and '{1}' order by accDate DESC, accID DESC",timeStart,timeEnd);
            ManagerHelper mngHelper = new ManagerHelper();
            return mngHelper.GetDataSet(sql).Tables[0];
        }

        //得到某段时间的收入
        public static DataTable GetPeriodIncome(string timeStart, string timeEnd)
        {
            string sql = string.Format(@"select accID ID,accDate 日期,classAccInOut 收支,accNum 数目,classAccName 分类,accCon 备注 
                                        from account inner join classAcc on account.classAccID=classAcc.classAccID 
                                        where classAccInOut='收入' and accDate between '{0}' and '{1}' order by accDate DESC, accID DESC", timeStart, timeEnd);
            ManagerHelper mngHelper = new ManagerHelper();
            return mngHelper.GetDataSet(sql).Tables[0];
        }

        //得到某段时间的支出
        public static DataTable GetPeriodOutcome(string timeStart, string timeEnd)
        {
            string sql = string.Format(@"select accID ID,accDate 日期,classAccInOut 收支,accNum 数目,classAccName 分类,accCon 备注 
                                        from account inner join classAcc on account.classAccID=classAcc.classAccID 
                                        where classAccInOut='支出' and accDate between '{0}' and '{1}' order by accDate DESC, accID DESC", timeStart, timeEnd);
            ManagerHelper mngHelper = new ManagerHelper();
            return mngHelper.GetDataSet(sql).Tables[0];
        }
        //得到收入或支出的全部分类
        public static DataTable GetAllInOutClass(int sign)
        {
            //sign==0为支出
            if(sign == 0)
            {
                string sql = string.Format(@"select * from classAcc where classAccInOut='支出'");
                ManagerHelper mngHelper = new ManagerHelper();
                return mngHelper.GetDataSet(sql).Tables[0];
            }
            //sign==1为收入
            if (sign == 1)
            {
                string sql = string.Format(@"select * from classAcc where classAccInOut='收入'");
                ManagerHelper mngHelper = new ManagerHelper();
                return mngHelper.GetDataSet(sql).Tables[0];
            }
            return null;
        }
        //查询账目分类是否已存在账目
        public static DataTable AccClassUsed(int classAccID)
        {
            string sql = string.Format(@"select * from account where classAccID={0}",classAccID);
            ManagerHelper mngHelper = new ManagerHelper();
            return mngHelper.GetDataSet(sql).Tables[0];
        }
        //增加分类
        public static bool AddAccClass(string classAccName, string classAccInOut)
        {
            string sql = String.Format(@"insert into classAcc(classAccName,classAccInOut) 
                                         values('{0}','{1}')", classAccName, classAccInOut);
            ManagerHelper mHelper = new ManagerHelper();
            return mHelper.ExecuteSql(sql);
        }
        //删除分类
        public static bool DelAccClass(int classAccID)
        {
            string sql = String.Format(@"delete classAcc where classAccID={0}", classAccID);
            ManagerHelper mHelper = new ManagerHelper();
            return mHelper.ExecuteSql(sql);
        }
        //查询某一分类名称是否存在
        public static DataTable ExistAccClassName(string classAccName, string classAccInOut)
        {
            string sql = string.Format(@"select * from classAcc where classAccName='{0}' and classAccInOut='{1}'",classAccName, classAccInOut);
            ManagerHelper mngHelper = new ManagerHelper();
            return mngHelper.GetDataSet(sql).Tables[0];
        }
        //增加账目
        public static bool AddAccount(double accNum,string accDate,int classAccID,int userID,string accCon)
        {
            string sql = String.Format(@"insert into account(accNum,accDate,classAccID,userID,accCon) 
                                         values('{0}','{1}',{2},{3},'{4}')", accNum,accDate,classAccID,userID,accCon);
            ManagerHelper mHelper = new ManagerHelper();
            return mHelper.ExecuteSql(sql);
        }
        //修改账目
        public static bool UPAccount(int accID,double accNum, string accDate, int classAccID, int userID, string accCon)
        {
            string sql = String.Format(@"update account set accNum={0},accDate='{1}',classAccID={2},userID={3},accCon='{4}'
                                         where accID={5}", accNum, accDate, classAccID, userID, accCon,accID);
            ManagerHelper mHelper = new ManagerHelper();
            return mHelper.ExecuteSql(sql);
        }
        //删除账目
        public static bool DelAccount(int accID)
        {
            string sql = String.Format(@"delete account where accID={0}", accID);
            ManagerHelper mHelper = new ManagerHelper();
            return mHelper.ExecuteSql(sql);
        }
        //得到余额下限值
        public static DataTable GetAccLimit()
        {
            string sql = string.Format(@"select * from accLimit");
            ManagerHelper mngHelper = new ManagerHelper();
            return mngHelper.GetDataSet(sql).Tables[0];
        }
        //修改余额下限制
        public static bool UPAccLimit(double accLimitNum)
        {
            string sql = String.Format(@"update accLimit set accLimitNum={0}", accLimitNum);
            ManagerHelper mHelper = new ManagerHelper();
            return mHelper.ExecuteSql(sql);
        }
        //查询账目的最后日期
        public static DataTable GetAccEndDate()
        {
            string sql = string.Format(@"select top 1 accDate
                                        from account
                                        order by accDate DESC");
            ManagerHelper mngHelper = new ManagerHelper();
            return mngHelper.GetDataSet(sql).Tables[0];
        }
        //查询项目的开始日期
        public static DataTable GetAccStartDate()
        {
            string sql = string.Format(@"select top 1 accDate
                                        from account
                                        order by accDate ASC");
            ManagerHelper mngHelper = new ManagerHelper();
            return mngHelper.GetDataSet(sql).Tables[0];
        }
        //得到所有预算
        public static DataTable GetAllBudget()
        {
            string sql = string.Format(@"select *  from budget order by budgetDate DESC");
            ManagerHelper mngHelper = new ManagerHelper();
            return mngHelper.GetDataSet(sql).Tables[0];
        }
        //查询预算是否已存在
        public static DataTable BudgetExist(string budgetDate)
        {
            string sql = string.Format(@"select *  from budget where budgetDate='{0}'",budgetDate);
            ManagerHelper mngHelper = new ManagerHelper();
            return mngHelper.GetDataSet(sql).Tables[0];
        }
        //增加预算
        public static bool AddBudget(string budgetDate,double budgetNum)
        {
            string sql = String.Format(@"insert into budget(budgetDate,budgetNum) 
                                         values('{0}',{1})", budgetDate, budgetNum);
            ManagerHelper mHelper = new ManagerHelper();
            return mHelper.ExecuteSql(sql);
        }
        //修改预算
        public static bool UPBudget(string budgetDate, double budgetNum)
        {
            string sql = String.Format(@"update budget set budgetNum={0} where 
                                         budgetDate='{1}'", budgetNum, budgetDate);
            ManagerHelper mHelper = new ManagerHelper();
            return mHelper.ExecuteSql(sql);
        }
        //删除预算
        public static bool DelBudget(int budgetID)
        {
            string sql = String.Format(@"delete budget where budgetID={0}", budgetID);
            ManagerHelper mHelper = new ManagerHelper();
            return mHelper.ExecuteSql(sql);
        }
    }
}
