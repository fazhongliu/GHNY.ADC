using System;
using System.ComponentModel;
using Volo.Abp.Auditing;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace GHNY.ADC.Farm
{
    /// <summary>
    /// 农场主信息
    /// </summary>
    [DisplayName("农场主/卖粮方信息")]
    public class Farmer : AuditedEntity<Guid>, ISoftDelete, IHasDeletionTime
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [DisplayName("姓名")]
        public string Name { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [DisplayName("电话")]
        public string Phone { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [DisplayName("性别")]
        public SexEnums? Sex { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        [DisplayName("民族")]
        public string Nation { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [DisplayName("省")]
        public string ProvinceId { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [DisplayName("市")]
        public string CityId { get; set; }

        /// <summary>
        /// 区(县)
        /// </summary>
        [DisplayName("区(县)")]
        public string DistrictId { get; set; }

        /// <summary>
        /// 镇(乡)
        /// </summary>
        [DisplayName("镇(乡、街道")]
        public string TownId { get; set; }

        /// <summary>
        /// 村(社区)
        /// </summary>
        [DisplayName("村(社区)")]
        public string VillageId { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [DisplayName("地址")]
        public string Address { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [DisplayName("身份证号")]
        public string IdCard { get; set; }

        /// <summary>
        /// 身份证开始有效期
        /// </summary>
        [DisplayName("身份证开始有效期")]
        public DateTime? IdCardStartDate { get; set; }

        /// <summary>
        /// 身份证结束有效期
        /// </summary>
        [DisplayName("身份证结束有效期")]
        public DateTime? IdCardEndDate { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        [DisplayName("开户银行")]
        public string BankName{ get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        [DisplayName("银行账号")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 账号姓名
        /// </summary>
        [DisplayName("账号姓名")]
        public string AccountName { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletionTime { get; set; }


        protected Farmer()
        {
        }

        public Farmer(
            Guid id,
            string name,
            string phone,
            SexEnums? sex,
            string nation,
            DateTime? birthday,
            string provinceId,
            string cityId,
            string districtId,
            string townId,
            string villageId,
            string address,
            string idCard,
            DateTime? idCardStartDate,
            DateTime? idCardEndDate,
            string bankName,
            string bankAccount,
            string accountName,
            bool isDeleted,
            DateTime? deletionTime
        ) : base(id)
        {
            Name = name;
            Phone = phone;
            Sex = sex;
            Nation = nation;
            ProvinceId = provinceId;
            CityId = cityId;
            DistrictId = districtId;
            TownId = townId;
            VillageId = villageId;
            Address = address;
            IdCard = idCard;
            IdCardStartDate = idCardStartDate;
            IdCardEndDate = idCardEndDate;
            BankName = bankName;
            BankAccount = bankAccount;
            AccountName = accountName;
            IsDeleted = isDeleted;
            DeletionTime = deletionTime;
        }
    }
}
