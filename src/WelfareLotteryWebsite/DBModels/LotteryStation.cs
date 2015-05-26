using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace WelfareLotteryWebsite.DBModels
{
    /// <summary>
    /// 网点信息
    /// </summary>
    public class LotteryStation
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 管理员
        /// </summary>
        public virtual Administrator Admin { get; set; }
        /// <summary>
        /// 网点编号
        /// </summary>
        public string StationCode { get; set; }
        /// <summary>
        /// 网站所在区域
        /// </summary>
        public virtual StationRegion Region { get; set; }
        /// <summary>
        /// 网点电话
        /// </summary>
        public string StationPhoneNo { get; set; }
        /// <summary>
        /// 销售站详细地址
        /// </summary>
        public string StationSpecificAddress { get; set; }
        /// <summary>
        /// 销售站地址标的物
        /// </summary>
        public string StationTarget { get; set; }
        /// <summary>
        /// 站点单双机情况[0:单机 1:双机]
        /// </summary>
        public bool MachineType { get; set; }
        /// <summary>
        /// 通讯类型[0:ADSL 1:CDMA]
        /// </summary>
        public bool CommunicationType { get; set; }
        /// <summary>
        /// 关联电话网络号
        /// </summary>
        public string RelatedPhoneNetNum { get; set; }
        /// <summary>
        /// 店面类型
        /// </summary>
        public virtual StationManageType ManageType { get; set; }
        /// <summary>
        /// 机主姓名
        /// </summary>
        public string HostName { get; set; }
        /// <summary>
        /// 机主Base64编号照片
        /// </summary>
        public string HostBase64Pic { get; set; }
        /// <summary>
        /// 机主电话[会有2个 可用$分隔开]
        /// </summary>
        public string HostPhoneNum { get; set; }
        /// <summary>
        /// 机主身份证号码
        /// </summary>
        public string HostIdentityNo { get; set; }
        /// <summary>
        /// 机主身份证正反面照片[由于是2张 可用"和"字区分 因其中不会有汉字]
        /// </summary>
        public string HostBase64IdentityPic { get; set; }
        /// <summary>
        /// 机主身份证地址
        /// </summary>
        public string HostIdentityAddress { get; set; }
        /// <summary>
        /// 担保人姓名
        /// </summary>
        public string GuaranteeName { get; set; }
        /// <summary>
        /// 担保人身份证正反面照片[由于是2张 可用"和"字区分 因其中不会有汉字]
        /// </summary>
        public string GuaranteeBase64IdentityPic { get; set; }
        /// <summary>
        /// 销售员列表
        /// </summary>
        public virtual List<Salesclerk> SalesmanList { get; set; }
        /// <summary>
        /// 福彩游戏类型
        /// </summary>
        public virtual WelfareLotteryGameType WelfareGameType { get; set; }
        /// <summary>
        /// 店面经营使用面积
        /// </summary>
        public string UsableArea { get; set; }
        /// <summary>
        /// 销售站店面产权[0:租赁 1:自有]
        /// </summary>
        public bool PropertyRight { get; set; }
        /// <summary>
        /// 租金折价
        /// </summary>
        public string RentDiscount { get; set; }
        /// <summary>
        /// 成立时间
        /// </summary>
        public DateTime? EstablishedTime { get; set; }
        /// <summary>
        /// 代销证编码
        /// </summary>
        public string AgencyNum { get; set; }
        /// <summary>
        /// 交款卡卡号
        /// </summary>
        public string DepositCardNo { get; set; }
        /// <summary>
        /// 即开奖励卡
        /// </summary>
        public virtual RewardCardInfo RewardCard { get; set; }
        /// <summary>
        /// 网点变更信息
        /// </summary>
        public virtual StationModifiedInfo ModifiedInfo { get; set; }
        /// <summary>
        /// 网站照片 [可按网点编号新建文件夹 在其下面存放它的照片]
        /// </summary>
        public List<string> StationPicList { get; set; }
        public string StationPicListSerialized
        {
            get{return JsonConvert.SerializeObject(StationPicList);}
            set { StationPicList = JsonConvert.DeserializeObject<List<string>>(value); }
        }
        /// <summary>
        /// 违规信息
        /// </summary>
        public string Violation { get; set; }
        /// <summary>
        /// 体彩店信息
        /// </summary>
        public virtual SportLottery SportLotteryInfo { get; set; }
    }

    /// <summary>
    /// 管理员信息
    /// </summary>
    public class Administrator
    {
        /// <summary>
        /// 标识序号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 管理员名字
        /// </summary>
        public string AdminName { get; set; }
    }

    /// <summary>
    /// 网点所属区域
    /// </summary>
    public class StationRegion
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 区域名称
        /// </summary>
        public string RegionName { get; set; }
    }

    /// <summary>
    /// 店面类型
    /// </summary>
    public class StationManageType
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 详情列表
        /// </summary>
        public List<string> DetailsList { get; set; }
        public string DetailsListSerialized
        {
            get
            {
                return JsonConvert.SerializeObject(DetailsList);
            }
            set
            {
                DetailsList = JsonConvert.DeserializeObject<List<string>>(value);
            }
        }
    }

    /// <summary>
    /// 即开奖励卡信息
    /// </summary>
    public class RewardCardInfo
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 卡主姓名
        /// </summary>
        public string CardName { get; set; }
        /// <summary>
        /// 卡主身份证号码
        /// </summary>
        public string CardIdentityNo { get; set; }
        /// <summary>
        /// 奖励卡号
        /// </summary>
        public string CardNum { get; set; }
    }

    /// <summary>
    /// 网点变更信息
    /// </summary>
    public class StationModifiedInfo
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 网点变更的类型
        /// </summary>
        public virtual StationModifiedType ModifiedType { get; set; }
        /// <summary>
        /// 网点变更备注信息
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// 变更日期
        /// </summary>
        public DateTime ModifiedTime { get; set; }
    }

    /// <summary>
    /// 网点变更类型
    /// </summary>
    public class StationModifiedType
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 变更后的类型名称
        /// </summary>
        public string TypeName { get; set; }
    }

    /// <summary>
    /// 体彩店信息
    /// </summary>
    public class SportLottery
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 体彩编号
        /// </summary>
        public string LotteryCode { get; set; }
        /// <summary>
        /// 进店日期
        /// </summary>
        public DateTime? IncomingDate { get; set; }
        /// <summary>
        /// 体彩机主姓名
        /// </summary>
        public string SportLotteryHostName { get; set; }
        /// <summary>
        /// 联系电话[固话或手机]
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 是否安装11选5
        /// </summary>
        public bool IsInstall { get; set; }
        /// <summary>
        /// 体彩游戏类型
        /// </summary>
        public virtual SportLotteryGameType GameType { get; set; }
        /// <summary>
        /// 与福彩机主关系
        /// </summary>
        public string Relation { get; set; }
    }
    
    /// <summary>
    /// 体彩游戏类型
    /// </summary>
    public class SportLotteryGameType
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 游戏类型
        /// </summary>
        public string GameType { get; set; }
    }

    /// <summary>
    /// 福彩游戏类型
    /// </summary>
    public class WelfareLotteryGameType
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 游戏类型
        /// </summary>
        public string GameType { get; set; }
        /// <summary>
        /// 游戏返点数
        /// </summary>
        public string Rebate { get; set; }
    }

    /// <summary>
    /// 销售员信息
    /// </summary>
    public class Salesclerk
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 销售员姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 销售员电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 销售员头像照片1张
        /// </summary>
        public string HeadPortraitBase64Pic { get; set; }
        /// <summary>
        /// 销售员身份证号码
        /// </summary>
        public string IdentityNo { get; set; }
        /// <summary>
        /// 销售员身份证地址
        /// </summary>
        public string IdentityAddress { get; set; }
    }
}
