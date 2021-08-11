using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewZealand_Courier.Models
{
    public class CourierDeliver
    {
        [Key]
        //Delivery Id
        public int Id { get; set; }
        //DeliveryPerson Name
       
        public string DeliveryPerson_Name { get; set; }
       
        //DeliveryPerson Address
        public string DeliveryPerson_Address { get; set; }
        //DeliveryPerson Contact
        public string DeliveryPerson_Contact { get; set; }
        //DeliveryPerson EmailId
        public string DeliveryPerson_EmailId { get; set; }
    }
}
