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
    [Table("CarTechInfo")]
    class CarTechInfo
    {
       
        [Key]
        public int carModelID { get; set; }
        public string carMark { get; set; }
        public string carModelName { get; set; }
        public string carComplectation { get; set; }
        public int carPower { get; set; }
        public string carGear { get; set; }
        public int carEngine { get; set; }
        public string carFuelTank { get; set; }
        public int carPlaces { get; set; }
        public int carFuelConsumption { get; set; }
    }
}
