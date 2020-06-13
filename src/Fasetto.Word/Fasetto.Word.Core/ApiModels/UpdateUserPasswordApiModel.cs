using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The password for an API client to update password on the server
    /// </summary>
    public class UpdateUserPasswordApiModel
    {
        /// <summary>
        /// The current password of the user
        /// </summary>
        public string CurrentPassword { get; set; }

        /// <summary>
        /// The new password to change
        /// </summary>
        public string NewPassword { get; set; }
    }
}
