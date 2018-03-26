using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upstack_MVC_API.ViewModel
{
    public class PersonViewModel
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }
        
        [MaxLength(20)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [MaxLength(20)]
        public string LastName { get; set; }
    }
}
