using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WeiXin_Contracts
{
    /// <summary>
    /// 微信App
    /// </summary>
    public class WeiXiApp 
    {
        /// <summary>
        /// appId
        /// </summary>
        public string appId;
        /// <summary>
        /// 密钥
        /// </summary>
        public string appSecret;
        /// <summary>
        /// 登录临时code
        /// </summary>
        public string js_code;
        /// <summary>
        /// 授权类型
        /// </summary>
        public string grant_type = "authorization_code";
    }
    /// <summary>
    /// 登录用户
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户唯一标识
        /// </summary>
        public string openid;
        /// <summary>
        /// 会话密钥
        /// </summary>
        public string session_key;
        /// <summary>
        /// 用户在开放平台的唯一标识符
        /// </summary>
        public string unionid;
        /// <summary>
        /// 错误码
        /// </summary>
        public int errcode = 0;
        /// <summary>
        /// 错误信息
        /// </summary>
        public string errMsg;
    }
    /// <summary>
    /// 凭证
    /// </summary>
    public class Token
    {
        /// <summary>
        /// 凭证
        /// </summary>
        public string access_token;
        /// <summary>
        /// 凭证有效时间，单位：秒
        /// </summary>
        public int expires_in;
        /// <summary>
        /// 错误码
        /// </summary>
        public int errcode = 0;
        /// <summary>
        /// 错误信息
        /// </summary>
        public string errMsg;
    }
    /// <summary>
    /// 用户信息
    /// </summary>
    [DataContract]
    public class Owner
    {
        /// <summary>
        /// 用户唯一标识
        /// </summary>
        [DataMember]
        public string OpenId { set; get; }
        /// <summary>
        /// 用户编号
        /// </summary>
        [DataMember]
        public string No { set; get; }
        /// <summary>
        /// 用户名称
        /// </summary>
        [DataMember]
        public string Name { set; get; }
        /// <summary>
        /// 用户电话
        /// </summary>
        [DataMember]
        public string Tele { set; get; }
        /// <summary>
        /// 证件号
        /// </summary>
        [DataMember]
        public string CertNo { set; get; }
        /// <summary>
        /// 住址
        /// </summary>
        [DataMember]
        public string Addr { set; get; }
        /// <summary>
        /// 表集合
        /// </summary>
        [DataMember]
        public List<Meter> MeterList { set; get; }
    }
    /// <summary>
    /// 表信息
    /// </summary>
    [DataContract]
    public class Meter
    {
        /// <summary>
        /// 表号
        /// </summary>
        [DataMember]
        public string No { set; get; }
        /// <summary>
        /// 表地址
        /// </summary>
        [DataMember]
        public string Addr { set; get; }
        /// <summary>
        /// 表类型
        /// </summary>
        [DataMember]
        public string Type { set; get; }
    }
    /// <summary>
    /// 日数据
    /// </summary>
    [DataContract]
    public class DayData
    {
        /// <summary>
        /// 表号
        /// </summary>
        [DataMember]
        public string MeterNo { set; get; }
        /// <summary>
        /// 上次抄表时间
        /// </summary>
        [DataMember]
        public string DayLTime { set; get; }
        /// <summary>
        /// 最后一次抄表时间
        /// </summary>
        [DataMember]
        public string DayTime { set; get; }
        /// <summary>
        /// 上次抄表读数
        /// </summary>
        [DataMember]
        public double DayLNumber { set; get; }
        /// <summary>
        /// 最后一次抄表读数
        /// </summary>
        [DataMember]
        public double DayNumber { set; get; }
        /// <summary>
        /// 用量
        /// </summary>
        [DataMember]
        public double DaySAmount { set; get; }
        /// <summary>
        /// 剩余金额
        /// </summary>
        [DataMember]
        public double DaySurplus{ set; get; }
    }
    /// <summary>
    /// 充值记录
    /// </summary>
    [DataContract]
    public class RechargeData
    {
        /// <summary>
        /// 表号
        /// </summary>
        [DataMember]
        public string MeterNo { set; get; }
        /// <summary>
        /// 充值时间
        /// </summary>
        [DataMember]
        public string BuyTime { set; get; }
        /// <summary>
        /// 充值金额
        /// </summary>
        [DataMember]
        public double BuyAmount { set; get; }
    }
}
