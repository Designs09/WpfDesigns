using System;
using System.Security;
using System.Runtime.InteropServices;

namespace Fasetto.Word
{
    /// <summary>
    /// Helpers for <see cref="SecureString"/>
    /// </summary>
    public static class SecureStringHelper
    {
        /// <summary>
        /// Unsecure a <see cref="SecureString"/> to plain text
        /// </summary>
        /// <param name="securePassword"></param>
        /// <returns></returns>
        public static string Unsecure(this SecureString securePassword)
        {
            // Make sure we have a secure string
            if (securePassword == null)
                return string.Empty;

            // Get a point for a unsecure stirng in memory
            var unmanagedString = IntPtr.Zero;

            try
            {
                // Unsecure the password
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                // Clear up any memory allocation
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}
