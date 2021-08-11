using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewZealand_Courier.Models
{
    public class CourierOffice
    {
        [Key]
        //Office  Id
        public int Id { get; set; }
        //Office Name
        public string Office_Name { get; set; }

        //Contact Number
        public string Contact_Number { get; set; }
        //Email Id
        public string Location { get; set; }
    }
}
