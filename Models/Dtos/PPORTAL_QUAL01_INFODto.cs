﻿using ESD_EDI_BE.Models.Dtos.Common;
using System.ComponentModel.DataAnnotations;

namespace ESD_EDI_BE.Models.Dtos
{
    public class PPORTAL_QUAL01_INFODto : BaseModel
    {
        public long Id { get; set; }
        [StringLength(20)]
        public string GR_CD { get; set; }
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
        [StringLength(50)]
        public string INV_NO { get; set; }
        [StringLength(14)]
        public string INV_MAPPING_DTTM { get; set; }
        [StringLength(20)]
        public string PPORTAL_ITEM_GROUP { get; set; }
        [StringLength(20)]
        public string QMS_ITEM_GROUP { get; set; }
        [StringLength(30)]
        public string ITEM_CODE { get; set; }
        [StringLength(100)]
        public string BARCODE_NO { get; set; }
        [StringLength(20)]
        public string LARGEBOX_QTY { get; set; }
        [StringLength(100)]
        public string S_BARCODE_NO { get; set; }
        [StringLength(20)]
        public string SMALLBOX_QTY { get; set; }
        [StringLength(50)]
        public string QUAL_INFO1 { get; set; }
        [StringLength(50)]
        public string QUAL_INFO2 { get; set; }
        [StringLength(50)]
        public string QUAL_INFO3 { get; set; }
        [StringLength(50)]
        public string QUAL_INFO4 { get; set; }
        [StringLength(50)]
        public string QUAL_INFO5 { get; set; }
        [StringLength(50)]
        public string QUAL_INFO6 { get; set; }
        [StringLength(50)]
        public string QUAL_INFO7 { get; set; }
        [StringLength(50)]
        public string QUAL_INFO8 { get; set; }
        [StringLength(50)]
        public string QUAL_INFO9 { get; set; }
        [StringLength(50)]
        public string QUAL_INF10 { get; set; }
        [StringLength(50)]
        public string QUAL_INF11 { get; set; }
        [StringLength(50)]
        public string QUAL_INF12 { get; set; }
        [StringLength(50)]
        public string QUAL_INF13 { get; set; }
        [StringLength(50)]
        public string QUAL_INF14 { get; set; }
        [StringLength(50)]
        public string QUAL_INF15 { get; set; }
        [StringLength(50)]
        public string QUAL_INF16 { get; set; }
        [StringLength(50)]
        public string QUAL_INF17 { get; set; }
        [StringLength(50)]
        public string QUAL_INF18 { get; set; }
        [StringLength(50)]
        public string QUAL_INF19 { get; set; }
        [StringLength(50)]
        public string QUAL_INF20 { get; set; }
        [StringLength(5)]
        public string QUAL_INF21 { get; set; }
        [StringLength(5)]
        public string QUAL_INF22 { get; set; }
        [StringLength(5)]
        public string QUAL_INF23 { get; set; }
        [StringLength(5)]
        public string QUAL_INF24 { get; set; }
        [StringLength(5)]
        public string QUAL_INF25 { get; set; }
        [StringLength(5)]
        public string QUAL_INF26 { get; set; }
        [StringLength(5)]
        public string QUAL_INF27 { get; set; }
        [StringLength(5)]
        public string QUAL_INF28 { get; set; }
        [StringLength(5)]
        public string QUAL_INF29 { get; set; }
        [StringLength(5)]
        public string QUAL_INF30 { get; set; }
        [StringLength(5)]
        public string QUAL_INF31 { get; set; }
        [StringLength(5)]
        public string QUAL_INF32 { get; set; }
        [StringLength(5)]
        public string QUAL_INF33 { get; set; }
        [StringLength(5)]
        public string QUAL_INF34 { get; set; }
        [StringLength(5)]
        public string QUAL_INF35 { get; set; }
        [StringLength(5)]
        public string QUAL_INF36 { get; set; }
        [StringLength(5)]
        public string QUAL_INF37 { get; set; }
        [StringLength(5)]
        public string QUAL_INF38 { get; set; }
        [StringLength(5)]
        public string QUAL_INF39 { get; set; }
        [StringLength(5)]
        public string QUAL_INF40 { get; set; }
        [StringLength(5)]
        public string QUAL_INF41 { get; set; }
        [StringLength(5)]
        public string QUAL_INF42 { get; set; }
        [StringLength(5)]
        public string QUAL_INF43 { get; set; }
        [StringLength(5)]
        public string QUAL_INF44 { get; set; }
        [StringLength(5)]
        public string QUAL_INF45 { get; set; }
        [StringLength(5)]
        public string QUAL_INF46 { get; set; }
        [StringLength(5)]
        public string QUAL_INF47 { get; set; }
        [StringLength(5)]
        public string QUAL_INF48 { get; set; }
        [StringLength(5)]
        public string QUAL_INF49 { get; set; }
        [StringLength(5)]
        public string QUAL_INF50 { get; set; }
        [StringLength(20)]
        public string TRANSACTION_ID { get; set; }
        [StringLength(1)]
        public string STATUS { get; set; }
        [StringLength(1)]
        public string ERR_FLAG { get; set; }
        [StringLength(8)]
        public string SUP_CREATE_DATE { get; set; }
        [StringLength(6)]
        public string SUP_CREATE_TIME { get; set; }
        [StringLength(8)]
        public string SUP_DATE_ADDED { get; set; }
        [StringLength(6)]
        public string SUP_TIME_ADDED { get; set; }
        [StringLength(8)]
        public string SUP_SEND_DATE { get; set; }
        [StringLength(6)]
        public string SUP_SEND_TIME { get; set; }
        [StringLength(100)]
        public string FIELD1 { get; set; }
        [StringLength(100)]
        public string FIELD2 { get; set; }
        [StringLength(100)]
        public string FIELD3 { get; set; }
        [StringLength(100)]
        public string FIELD4 { get; set; }
        [StringLength(100)]
        public string FIELD5 { get; set; }
    }
}
