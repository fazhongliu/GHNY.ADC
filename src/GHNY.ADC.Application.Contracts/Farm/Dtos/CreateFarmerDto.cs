using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GHNY.ADC.Farm.Dtos
{
  public class CreateFarmerDto
    {
        [DisplayName("姓名")]
        public string Name { get; set; }

        [DisplayName("电话")]
        public string Phone { get; set; }

        [DisplayName("性别")]
        public SexEnums Sex { get; set; }

        [DisplayName("民族")]
        public string Nation { get; set; }

        [DisplayName("出生日期")]
        public DateTime? Birthday { get; set; }

        [DisplayName("省")]
        public string ProvinceId { get; set; }

        [DisplayName("市")]
        public string CityId { get; set; }

        [DisplayName("区(县)")]
        public string DistrictId { get; set; }

        [DisplayName("镇(乡)")]
        public string TownId { get; set; }

        [DisplayName("村(社区)")]
        public string VillageId { get; set; }

        [DisplayName("地址")]
        public string Address { get; set; }

        [DisplayName("身份证号")]
        public string IDCard { get; set; }

        [DisplayName("身份证开始有效期")]
        public DateTime? IDCardStartDate { get; set; }

        [DisplayName("身份证结束有效期")]
        public DateTime? IDCardEndDate { get; set; }
        [DisplayName("开户银行")]
        public string BankName { get; set; }

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
    }
}
