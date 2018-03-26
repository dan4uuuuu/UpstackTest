using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upstack_MVC_API.Model
{
    public class Person
    {
        [Required]
        public int Id { get; set; }


        [MaxLength(20)]
        public string FirstName { get; set; }

        [MaxLength(20)]
        public string LastName { get; set; }
    }
}
