using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName("pay Mode Id")]
        public int Id { get; set; }
        [DisplayName("pay Mode Name")]
        [Required(ErrorMessage = "Pay mode name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pay mode name must be between 3 and 50 characteres")]
        public string Name { get; set; }
        [DisplayName("observation")]
        [Required(ErrorMessage = "Pay mode observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Pay mode observation must be between 3 and 200 characteres")]
        public int Observation { get; set; }
    }
}
