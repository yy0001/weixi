using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using WeiXin_Contracts;

namespace WeiXin_Services
{
    public class Service : IService
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="code">临时登录code</param>
        /// <returns>用户标识openId</returns>
        public string Login(string code)
        {

            return "";
        }
        /// <summary>
        /// 绑定用户表计
        /// </summary>
        /// <param name="openId">用户标识openId</param>
        /// <param name="certNo">证件号</param>
        /// <returns>用户表数据</returns>
        public Owner BindMeter(string openId, string certNo) 
        {
            return new Owner();
        }
        /// <summary>
        /// 查询最后一次抄表的数据
        /// </summary>
        /// <param name="meterNo">表号</param>
        /// <returns>表数据</returns>
        public DayData QueryDayData(string meterNo)
        {
            return new DayData(); 
        }
        /// <summary>
        /// 查询用户充值记录
        /// </summary>
        /// <param name="openId">用户标识</param>
        /// <param name="sTime">开始时间</param>
        /// <param name="eTime">结束时间</param>
        /// <returns>返回充值记录</returns>
        public List<RechargeData> QueryRechargeData(string openId, string sTime, string eTime) 
        { 
            return new List<RechargeData>(); 
        }
        /// <summary>
        /// 用户充值
        /// </summary>
        /// <param name="meterNo">表号</param>
        /// <param name="amount">金额</param>
        /// <returns>是否成功</returns>
        public bool Recharge(string meterNo, double amount) 
        { 
            return true;
        }
    }
}
