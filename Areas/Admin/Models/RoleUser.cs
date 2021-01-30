using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Online_Shopping_Store.Areas.Admin.Models
{
    public class RoleUser
    {
        [Required]
        [Display(Name ="User")]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "Role")]
        public string RoleId { get; set; }
    }
}
