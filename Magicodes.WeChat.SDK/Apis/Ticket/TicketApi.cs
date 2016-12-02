// ======================================================================
//  
//          Copyright (C) 2016-2020 ����������Ϣ�Ƽ����޹�˾    
//          All rights reserved
//  
//          filename : TicketApi.cs
//          description :
//  
//          created by ����ǿ at  2016/09/23 17:10
//          Blog��http://www.cnblogs.com/codelove/
//          GitHub �� https://github.com/xin-lai
//          Home��http://xin-lai.com
//  
// ======================================================================

using System;
using System.Collections.Generic;

namespace Magicodes.WeChat.SDK.Apis.Ticket
{
    /// <summary>
    ///     �ͷ��ӿ�
    /// </summary>
    public class TicketApi : ApiBase
    {
        private const string ApiName = "ticket";

        /// <summary>
        ///     ��ȡAccessToken
        /// </summary>
        /// <returns></returns>
        public TicketApiResult Get()
        {
            var url = GetAccessApiUrl("getticket", ApiName, ApiRoot, new Dictionary<string, string>
            {
                {"type", "jsapi"}
            });
            var result = Get<TicketApiResult>(url);
            result.ExporesTime = DateTime.Now.AddSeconds(result.Expires - 30);
            return result;
        }

        /// <summary>
        ///     ��ȫ��ȡAccessToken
        /// </summary>
        /// <returns></returns>
        public TicketApiResult SafeGet()
        {
            var appConfig = AppConfig;
            TicketApiResult ticket;
            if (WeChatConfigManager.Current.TicketConcurrentDictionary.ContainsKey(appConfig.AppId))
            {
                ticket = WeChatConfigManager.Current.TicketConcurrentDictionary[appConfig.AppId];
                if (DateTime.Now < ticket.ExporesTime)
                    return ticket;
                ticket = Get();
                WeChatConfigManager.Current.TicketConcurrentDictionary.AddOrUpdate(appConfig.AppId, ticket,
                    (tKey, existingVal) => ticket);
                return ticket;
            }
            ticket = Get();
            WeChatConfigManager.Current.TicketConcurrentDictionary.AddOrUpdate(appConfig.AppId, ticket,
                (tKey, existingVal) => ticket);
            return ticket;
        }
    }
}