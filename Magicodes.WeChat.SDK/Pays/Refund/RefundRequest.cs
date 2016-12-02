﻿using System;
using System.Xml.Serialization;

namespace Magicodes.WeChat.SDK.Pays.Refund
{
    [Serializable]
    [XmlRoot("xml")]
    public class RefundRequest
    {
        /// <summary>
        ///     微信分配的公众账号ID
        /// </summary>
        [XmlElement("appid")]
        public string AppId { get; set; }

        /// <summary>
        ///     微信支付分配的商户号
        /// </summary>
        [XmlElement("mch_id")]
        public string Mch_Id { get; set; }

        /// <summary>
        ///     微信支付分配的终端设备号
        /// </summary>
        [XmlElement("device_info")]
        public string Device_Info { get; set; }

        /// <summary>
        ///     随机字符串，不长于32 位
        /// </summary>
        [XmlElement("nonce_str")]
        public string NonceStr { get; set; }

        /// <summary>
        ///     签名
        /// </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 微信生成的订单号，在支付通知中有返回
        /// </summary>
        [XmlElement("transaction_id")]
        public string Transaction_id
        {
            get;
            set;
        }

        /// <summary>
        /// 商户传给微信的订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string Out_trade_no
        {
            get;
            set;
        }

        /// <summary>
        /// 商户系统内部的退款单号，商户系统内部唯一，同一退款单号多次请求只退一笔
        /// </summary>
        [XmlElement("out_refund_no")]
        public string Out_refund_no
        {
            get;
            set;
        }

        /// <summary>
        /// 订单总金额，单位为分，只能为整数
        /// </summary>
        [XmlElement("total_fee")]
        public int Total_fee
        {
            get;
            set;
        }

        /// <summary>
        /// 退款总金额，订单总金额，单位为分，只能为整数
        /// </summary>
        [XmlElement("refund_fee")]
        public int Refund_fee
        {
            get;
            set;
        }

        /// <summary>
        /// 货币类型，符合ISO 4217标准的三位字母代码，默认人民币：CNY，其他值列表详见货币类型
        /// </summary>
        [XmlElement("refund_fee_type")]
        public string Refund_fee_type
        {
            get;
            set;
        }

        /// <summary>
        /// 操作员帐号, 默认为商户号
        /// </summary>
        [XmlElement("op_user_id")]
        public string Op_user_id
        {
            get;
            set;
        }

        /// <summary>
        /// 仅针对老资金流商户使用REFUND_SOURCE_UNSETTLED_FUNDS---未结算资金退款（默认使用未结算资金退款）REFUND_SOURCE_RECHARGE_FUNDS---可用余额退款
        /// </summary>
        [XmlElement("refund_account")]
        public string Refund_account
        {
            get;
            set;
        }
    }
}
