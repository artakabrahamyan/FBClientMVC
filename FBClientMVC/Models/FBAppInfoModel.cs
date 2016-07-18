using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FBClientMVC.Models
{
    public class FBAppInfoModel
    {
        [Required]
        [Display(Name = "Facebook AppID")]
        public string AppID { get; set; }

        [Required]
        [Display(Name = "Facebook SecretKey")]
        public string AppSecretKey { get; set; }

        [Required]
        [Display(Name = "Facebook Page ID")]
        public string PageID { get; set; }

        [Required]
        [Display(Name = "Posted Topic Filter")]
        public string TopicFilter { get; set; }
    }
}