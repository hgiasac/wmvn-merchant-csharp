
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using WM.Merchant.Helpers;

namespace WM.Merchant.Base
{
    public abstract class WMResponseModel : WMModel
    {   
        /// <summary>
        /// Hashes checksum value with passcode and secret
        /// </summary>
        /// <param name="secret">Secret key which is provided by Webmoney</param>
        public void HashChecksum(string secret)
        {
            string message = this.HashMessage();
            this.Checksum = SecurityHelper.HMACHSA1(message, secret);
        }
    }
}
