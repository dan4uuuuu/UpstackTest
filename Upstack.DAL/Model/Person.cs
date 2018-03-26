using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upstack.DAL.Model
{
    public class Person
    {

        [Key]
        [Required]
        public int Id { get; set; }


        [MaxLength(20)]
        public string FirstName { get; set; }

        [MaxLength(20)]
        public string LastName { get; set; }
    }
}
