using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Credentials;

namespace MusicApp.Utils
{
    public static class MicrosoftPassportHelper
    {
        public static async Task<bool> MicrosoftPassportAvailableCheckAsync()
        {
            bool keyCredentialAvailable = await KeyCredentialManager.IsSupportedAsync();
            if (keyCredentialAvailable == false)
            {
                Debug.WriteLine("Microsoft Passport is not setup!\nPlease go to Windows Settings and set up a PIN to use it.");
                return false;
            }
            return true;
        }
    }
}
