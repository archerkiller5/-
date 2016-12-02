// ======================================================================
//  
//          Copyright (C) 2016-2020 ����������Ϣ�Ƽ����޹�˾    
//          All rights reserved
//  
//          filename : CardApi.cs
//          description :
//  
//          created by ����ǿ at  2016/10/13 17:10
//          Blog��http://www.cnblogs.com/codelove/
//          GitHub��https://github.com/xin-lai
//          Home��http://xin-lai.com
//  
// ======================================================================

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Magicodes.WeChat.SDK.Apis.Card
{
    /// <summary>
    ///     ��ȯ�ӿ�
    /// </summary>
    public class CardApi : ApiBase
    {
        private const string ApiName = "card";

        /// <summary>
        ///     ��ӿ�ȯ
        /// </summary>
        /// <param name="cardInfo">��ȯ�ṹ����</param>
        /// <returns></returns>
        public ApiResult Add(CardInfo cardInfo)
        {
            //��ȡapi����url
            var url = GetAccessApiUrl("create", ApiName, "https://api.weixin.qq.com");
            var data = new
            {
                card = cardInfo
            };
            var result = Post<ApiResult>(url, data);
            return result;
        }

        /// <summary>
        ///     ��ӿ�ȯ
        /// </summary>
        /// <param name="cardInfoJson">��ȯJSON�ṹ�ַ���</param>
        /// <returns></returns>
        public ApiResult AddByJson(string cardInfoJson)
        {
            return Add(GetCardInfoByJson(cardInfoJson));
        }

        /// <summary>
        ///     ���ݿ�ȯJSON�ṹ�ַ�����ȡ��ȯ��Ϣ
        /// </summary>
        /// <returns></returns>
        public CardInfo GetCardInfoByJson(string cardInfoJson)
        {
           return JsonConvert.DeserializeObject<CardInfo>(cardInfoJson, new CardInfoCustomConverter(), new DateInfoCustomConverter());
        }

        /// <summary>
        ///     �ϴ���ȯͼƬ
        /// </summary>
        /// <param name="fileName">�ļ���</param>
        /// <param name="fileStream">�ļ���</param>
        /// <returns></returns>
        public UploadImageApiResult UploadImage(string fileName, Stream fileStream)
        {
            //��ȡapi����url
            var url = GetAccessApiUrl("uploadimg", "media");
            return Post<UploadImageApiResult>(url, fileName, fileStream);
        }

    }
}