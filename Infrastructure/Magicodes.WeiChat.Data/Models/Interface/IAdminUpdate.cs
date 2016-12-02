// ======================================================================
//  
//          Copyright (C) 2016-2020 ����������Ϣ�Ƽ����޹�˾    
//          All rights reserved
//  
//          filename : IAdminUpdate.cs
//          description :
//  
//          created by ����ǿ at  2016/09/26 16:06
//          Blog��http://www.cnblogs.com/codelove/
//          GitHub �� https://github.com/xin-lai
//          Home��http://xin-lai.com
//  
// ======================================================================

using System;

namespace Magicodes.WeiChat.Data.Models.Interface
{
    public interface IAdminUpdate<TUpdateByKey>
    {
        /// <summary>
        ///     ������
        /// </summary>
        TUpdateByKey UpdateBy { get; set; }

        /// <summary>
        ///     ����ʱ��
        /// </summary>
        DateTime? UpdateTime { get; set; }
    }
}