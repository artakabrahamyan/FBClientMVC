using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBClientMVC.Core.Models.FBClientMVC.Core
{
    public class FBClientModel
    {
        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Indicate if success or fault
        /// </summary>
        public bool Success { get; set; }
    }
}
