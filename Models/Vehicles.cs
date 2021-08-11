using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewZealand_Courier.Models
{
    public class Vehicles
    {
        [Key]
        //Delivery Id
        public int Id { get; set; }
        //DeliveryPerson Name

       

       public string DeliveryPerson_Name { get; set; }
        public CourierDeliver CourierDeliver { get; set; }
        
        //DeliveryPerson Name
        public string Vehicle_Name { get; set; }
        //DeliveryPerson Address
        public string Vehicle_Make { get; set; }
        //DeliveryPerson Contact
        public string Vehicle_Redgo { get; set; }
        //DeliveryPerson EmailId
        //public string DeliveryPerson_EmailId { get; set; }
    }
}
