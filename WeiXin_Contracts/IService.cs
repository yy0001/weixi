using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WeiXin_Contracts
{
    /// <summary>
    /// 微信业务服务
    /// </summary>
    [ServiceContract]
    public interface IService
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="code">临时登录code</param>
        /// <returns>用户标识openId</returns>
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Login", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string Login(string code);
        /// <summary>
        /// 绑定用户表计
        /// </summary>
        /// <param name="openId">用户标识openId</param>
        /// <param name="certNo">证件号</param>
        /// <returns>用户表数据</returns>
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "BindMeter", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Owner BindMeter(string openId, string certNo);
        /// <summary>
        /// 查询最后一次抄表的数据
        /// </summary>
        /// <param name="meterNo">表号</param>
        /// <returns>表数据</returns>
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "QueryDayData/{meterNo}", ResponseFormat = WebMessageFormat.Json)]
        DayData QueryDayData(string meterNo);
        /// <summary>
        /// 查询用户充值记录
        /// </summary>
        /// <param name="openId">用户标识</param>
        /// <param name="sTime">开始时间</param>
        /// <param name="eTime">结束时间</param>
        /// <returns>返回充值记录</returns>
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "QueryRechargeData/{openId}/{sTime}/{eTime}", ResponseFormat = WebMessageFormat.Json)]
        List<RechargeData> QueryRechargeData(string openId, string sTime, string eTime);
        /// <summary>
        /// 用户充值
        /// </summary>
        /// <param name="meterNo">表号</param>
        /// <param name="amount">金额</param>
        /// <returns>是否成功</returns>
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Recharge", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool Recharge(string meterNo, double amount);
    }
}
