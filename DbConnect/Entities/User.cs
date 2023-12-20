using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnect.Entities
{
    public class User
    {
        [Key]
        public int UserID {  get; set; }

        [Required]
        public string Username {  get; set; }

        [Required]
        public string Password { get; set; }
    }
}
