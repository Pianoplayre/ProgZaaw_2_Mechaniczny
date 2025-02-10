using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace HamburgerMenuDemo
{
    class Roles
    {
        [Key]
        public int roleID { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
    }
}
