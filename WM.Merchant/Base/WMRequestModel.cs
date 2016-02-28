
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
    public abstract class WMRequestModel : WMModel
    {   
        /// <summary>
        /// Hashes checksum value with passcode and secret
        /// </summary>
        /// <param name="passcode">Public passcode which is provided by Webmoney</param>
        /// <param name="secret">Secret key which is provided by Webmoney</param>
        public void HashChecksum(string passcode, string secret)
        {
            string message = this.HashMessage() + passcode;
            Checksum = SecurityHelper.HMACHSA1(message, secret);
        }
    }
}
