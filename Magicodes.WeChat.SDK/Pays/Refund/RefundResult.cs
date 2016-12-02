﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Magicodes.WeChat.SDK.Pays.TenPayV3
{
    /// <summary>
    /// 申请退款return_code为SUCCESS的时候有返回 
    /// </summary>
    [XmlRoot("xml")]
    [Serializable]
    public class RefundResult : Result
    {


        /// <summary>
        /// 微信订单号	是	String(28)	4007752501201407033233368018	微信订单号
        /// </summary>
        [XmlElement("transaction_id")]
        public string Transaction_id
        {
            get;
            set;
        }

        /// <summary>
        /// 商户订单号	是	String(32)	33368018	商户系统内部的订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string Out_trade_no
        {
            get;
            set;
        }

        /// <summary>
        /// 商户退款单号	是	String(32)	121775250	商户退款单号
        /// </summary>
        [XmlElement("out_refund_no")]
        public string Out_refund_no
        {
            get;
            set;
        }

        /// <summary>
        /// 微信退款单号	是	String(28)	2007752501201407033233368018	微信退款单号
        /// </summary>
        [XmlElement("refund_id")]
        public string Refund_id
        {
            get;
            set;
        }

        /// <summary>
        /// 退款渠道	否	String(16)	ORIGINAL	ORIGINAL—原路退款 BALANCE—退回到余额
        /// </summary>
        [XmlElement("refund_channel")]
        public string Refund_channel
        {
            get;
            set;
        }

        /// <summary>
        /// 申请退款金额	是	Int	100	退款总金额,单位为分,可以做部分退款
        /// </summary>
        [XmlElement("refund_fee")]
        public int Refund_fee
        {
            get;
            set;
        }

        /// <summary>
        /// 退款金额	否	Int	100	去掉非充值代金券退款金额后的退款金额，退款金额=申请退款金额-非充值代金券退款金额，退款金额<=申请退款金额
        /// </summary>
        [XmlElement("settlement_refund_fee")]
        public int Settlement_refund_fee
        {
            get;
            set;
        }

        /// <summary>
        /// 订单金额	是	Int	100	订单总金额，单位为分，只能为整数，详见支付金额
        /// </summary>
        [XmlElement("total_fee")]
        public int Total_fee
        {
            get;
            set;
        }

        /// <summary>
        /// 应结订单金额	否	Int	100	去掉非充值代金券金额后的订单总金额，应结订单金额=订单金额-非充值代金券金额，应结订单金额<=订单金额。
        /// </summary>
        [XmlElement("settlement_total_fee")]
        public int Settlement_total_fee
        {
            get;
            set;
        }

        /// <summary>
        /// 订单金额货币种类	否	String(8)	CNY	订单金额货币类型，符合ISO 4217标准的三位字母代码，默认人民币：CNY，其他值列表详见货币类型
        /// </summary>
        [XmlElement("fee_type")]
        public string Fee_type
        {
            get;
            set;
        }

        /// <summary>
        /// 现金支付金额	是	Int	100	现金支付金额，单位为分，只能为整数，详见支付金额
        /// </summary>
        [XmlElement("cash_fee")]
        public int Cash_fee
        {
            get;
            set;
        }

        /// <summary>
        /// 现金退款金额	否	Int	100	现金退款金额，单位为分，只能为整数，详见支付金额
        /// </summary>
        [XmlElement("cash_refund_fee")]
        public int Cash_refund_fee
        {
            get;
            set;
        }

        /// <summary>
        /// 代金券类型	否	String(8)	CASH	CASH--充值代金券 NO_CASH---非充值代金券 订单使用代金券时有返回（取值：CASH、NO_CASH）。$n为下标,从0开始编号，举例：coupon_type_0
        /// </summary>
        [XmlElement("coupon_type_0")]
        public string Coupon_type_0
        {
            get;
            set;
        }

        /// <summary>
        /// 代金券退款金额	否	Int	100	代金券退款金额小于等于退款金额，退款金额-代金券或立减优惠退款金额为现金，说明详见代金券或立减优惠
        /// </summary>
        [XmlElement("coupon_refund_fee_0")]
        public int Coupon_refund_fee_0
        {
            get;
            set;
        }

        /// <summary>
        /// 退款代金券使用数量	否	Int	1	退款代金券使用数量 ,$n为下标,从0开始编号
        /// </summary>
        [XmlElement("coupon_refund_count_0")]
        public int Coupon_refund_count_0
        {
            get;
            set;
        }

        /// <summary>
        /// 退款代金券批次ID	否	String(20)	100	退款代金券批次ID ,$n为下标，$m为下标，从0开始编号
        /// </summary>
        [XmlElement("coupon_refund_batch_id_0_0")]
        public string Coupon_refund_batch_id_0_0
        {
            get;
            set;
        }

        /// <summary>
        /// 退款代金券ID	否	String(20)	10000 	退款代金券ID, $n为下标，$m为下标，从0开始编号
        /// </summary>
        [XmlElement("coupon_refund_id_0_0")]
        public string Coupon_refund_id_0_0
        {
            get;
            set;
        }

        /// <summary>
        /// 单个退款代金券支付金额	否	Int	100	单个退款代金券支付金额, $n为下标，$m为下标，从0开始编号
        /// </summary>
        [XmlElement("coupon_refund_fee_0_0")]
        public int Coupon_refund_fee_0_0
        {
            get;
            set;
        }

        /// <summary>
        /// 是否成功
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccess()
        {
            return ReturnCode == "SUCCESS" && ResultCode == "SUCCESS";
        }
    }
}
