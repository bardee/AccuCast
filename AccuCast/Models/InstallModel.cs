using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AccuCast.Models
{
    public class InstallModel
    {
        [Required(ErrorMessage = "Zip is Required")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        public string zip { get; set; }
        [Required(ErrorMessage = "Please Accept the Terms of Services")]
        public string acpt { get; set; }
    }
}