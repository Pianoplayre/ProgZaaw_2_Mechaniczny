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
    public class Users
    {
       [Key]
        public int userId { get; set; }
        public int userRoleId { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userPhone { get; set; }

        public string userLogin { get; set; }
        public string userPassword { get; set; }
       


    }
}
