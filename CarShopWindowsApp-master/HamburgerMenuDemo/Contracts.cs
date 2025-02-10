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
    class Contracts
    {
        [Key]
        public int contractID { get; set; }
        public int orderID { get; set; }



    }
}
