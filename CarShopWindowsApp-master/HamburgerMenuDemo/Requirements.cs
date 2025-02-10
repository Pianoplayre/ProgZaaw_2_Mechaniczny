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
    class Requirements
    {
        [Key]
        public int reqID { get; set; }
        public int customerID { get; set; }
        public int carModelID { get; set; }
        public string carCategory { get; set; }
        public string carPower { get; set; }

        public string carGear { get; set; }
        public string carEngine { get; set; }
        public string carFuelTank { get; set; }
        public int carPlaces { get; set; }
        public int Budget { get; set; }
        public int managerID { get; set; }
        public int carID { get; set; }

    }
}
