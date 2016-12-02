// ======================================================================
//  
//          Copyright (C) 2016-2020 ����������Ϣ�Ƽ����޹�˾    
//          All rights reserved
//  
//          filename : MD5UtilHelper.cs
//          description :
//  
//          created by ����ǿ at  2016/09/23 17:10
//          Blog��http://www.cnblogs.com/codelove/
//          GitHub �� https://github.com/xin-lai
//          Home��http://xin-lai.com
//  
// ======================================================================

using System;
using System.Security.Cryptography;
using System.Text;

namespace Magicodes.WeChat.SDK.Helper
{
    /// <summary>
    ///     MD5UtilHelper ��ժҪ˵����
    /// </summary>
    public class MD5UtilHelper
    {
        /// <summary>
        ///     ��ȡ��д��MD5ǩ�����
        /// </summary>
        /// <param name="encypStr"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static string GetMD5(string encypStr, string charset)
        {
            string retStr;
            var m5 = new MD5CryptoServiceProvider();

            //����md5����
            byte[] inputBye;
            byte[] outputBye;

            //ʹ��GB2312���뷽ʽ���ַ���ת��Ϊ�ֽ����飮
            try
            {
                inputBye = Encoding.GetEncoding(charset).GetBytes(encypStr);
            }
            catch (Exception ex)
            {
                inputBye = Encoding.GetEncoding("GB2312").GetBytes(encypStr);
            }
            outputBye = m5.ComputeHash(inputBye);

            retStr = BitConverter.ToString(outputBye);
            retStr = retStr.Replace("-", "").ToUpper();
            return retStr;
        }
    }
}