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
    class Orders
    {
        [Key]
        public int orderID { get; set; }
        public int managerID { get; set; }
        public int customerID { get; set; }
        public string orderStatus { get; set; }
        public int price { get; set; }
        public int carID { get; set; }

    }
}
