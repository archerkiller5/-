// ======================================================================
//  
//          Copyright (C) 2016-2020 ����������Ϣ�Ƽ����޹�˾    
//          All rights reserved
//  
//          filename : POIApi.cs
//          description :
//  
//          created by ����ǿ at  2016/10/19 17:10
//          Blog��http://www.cnblogs.com/codelove/
//          GitHub��https://github.com/xin-lai
//          Home��http://xin-lai.com
//  
// ======================================================================

using System;
using System.Collections.Generic;
using System.IO;

namespace Magicodes.WeChat.SDK.Apis.POI
{
    /// <summary>
    ///     ��ȯ�ӿ�
    /// </summary>
    public class POIApi : ApiBase
    {
        private const string ApiName = "poi";

        /// <summary>
        /// ����ŵ�
        /// </summary>
        /// <param name="model">�ŵ���Ϣ</param>
        /// <returns></returns>
        public ApiResult Add(POIInfo model)
        {
            //��ȡapi����url
            var url = GetAccessApiUrl("addpoi", ApiName);
            var data = new
            {
                business = new
                {
                    base_info = model
                }
            };
            return Post<ApiResult>(url, data);
        }
        /// <summary>
        /// ɾ��POI
        /// </summary>
        /// <param name="poiId">�ŵ�ID������¼�����</param>
        /// <returns></returns>
        public ApiResult Remove(string poiId)
        {
            //��ȡapi����url
            var url = GetAccessApiUrl("delpoi", ApiName);
            var data = new
            {
                poi_id = poiId
            };
            return Post<ApiResult>(url, data);
        }

        /// <summary>
        /// ��ȡ�ŵ���ϸ��Ϣ
        /// </summary>
        /// <param name="poiId">�ŵ�ID������¼�����</param>
        /// <returns></returns>
        public GetPOIDetailInfoAPIResult GetPOIDetailInfo(string poiId)
        {
            //��ȡapi����url
            var url = GetAccessApiUrl("getpoi", ApiName);
            var data = new
            {
                poi_id = poiId
            };
            return Post<GetPOIDetailInfoAPIResult>(url, data);
        }

        /// <summary>
        /// ��ȡ�ŵ��б���Ϣ
        /// </summary>
        /// <param name="poiId">�ŵ�ID������¼�����</param>
        /// <returns></returns>
        public GetApiResult Get(int begin = 0, int limit = 10)
        {
            //��ȡapi����url
            var url = GetAccessApiUrl("getpoilist", ApiName);
            var data = new
            {
                begin = begin,
                limit = limit
            };
            return Post<GetApiResult>(url, data);
        }

        /// <summary>
        ///     ��ȡAccessToken
        /// </summary>
        /// <returns></returns>
        public GetCategoryListApiResult GetCategoryList()
        {
            //��ȡapi����url
            var url = GetAccessApiUrl("getwxcategory", ApiName);
            return Get<GetCategoryListApiResult>(url);
        }

        /// <summary>
        /// �ϴ��ŵ�ͼƬ
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