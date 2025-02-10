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
    class Cars
    {

        [Key]
        public int carID { get; set; }
        public int carModelID { get; set; }
        public string carType { get; set; }
        public string carCategory { get; set; }
        public string carDesc { get; set; }
        public int carPrice { get; set; }
        public int carOwnerID { get; set; }




    }
}
