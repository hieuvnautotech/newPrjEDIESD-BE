using System.ComponentModel.DataAnnotations;
using ESD_EDI_BE.Models.Dtos.Common;
using Microsoft.EntityFrameworkCore;


namespace ESD_EDI_BE.Models.Dtos
{
    public class PPORTAL_QUAL02_INFODto : BaseModel
    {
        public long Id { get; set; }
        [StringLength(10)]
        public string BUYER_COMPANY { get; set; }
        [StringLength(10)]
        public string BUYER_DIVISION { get; set; }
        [StringLength(10)]
        public string SELLER_COMPANY { get; set; }
        [StringLength(10)]
        public string SELLER_DIVISION { get; set; }
        [StringLength(10)]
        public string GBM { get; set; }
        [StringLength(20)]
        public string PPORTAL_ITEM_GROUP { get; set; }
        [StringLength(20)]
        public string QMS_ITEM_GROUP { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ITEM_CODE { get; set; }
        public int? CTQ_NO { get; set; }
        [StringLength(50)]
        public string YYYYMMDDHH { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PRC_QUAL_INFO01 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PRC_QUAL_INFO02 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PRC_QUAL_INFO03 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PRC_QUAL_INFO04 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PRC_QUAL_INFO05 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PRC_QUAL_INFO06 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PRC_QUAL_INFO07 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PRC_QUAL_INFO08 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PRC_QUAL_INFO09 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PRC_QUAL_INFO10 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PRC_QUAL_INFO11 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PRC_QUAL_INFO12 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PRC_QUAL_INFO13 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PRC_QUAL_INFO14 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PRC_QUAL_INFO15 { get; set; }
        [StringLength(20)]
        public string TRANSACTION_ID { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string STATUS { get; set; }
        [StringLength(1)]
        public string ERR_FLAG { get; set; }
        [StringLength(20)]
        public string SUP_CREATE_DATE { get; set; }
        [StringLength(20)]
        public string SUP_CREATE_TIME { get; set; }
        [StringLength(8)]
        public string SUP_DATE_ADDED { get; set; }
        [StringLength(6)]
        public string SUP_TIME_ADDED { get; set; }
        [StringLength(8)]
        public string SUP_SEND_DATE { get; set; }
        [StringLength(500)]
        public string namehmi { get; set; }
        [StringLength(6)]
        public string SUP_SEND_TIME { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string FIELD1 { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string FIELD2 { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string FIELD3 { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string FIELD4 { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string FIELD5 { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string FILE_NM { get; set; }
        [Precision(3)]
        public DateTime? REG_DT { get; set; }
        public long? REG_ID { get; set; }
        [Precision(3)]
        public DateTime? CHG_DT { get; set; }
        public long? CHG_ID { get; set; }
        public string TRAND_TP_NAME { get; set; }
    }
}