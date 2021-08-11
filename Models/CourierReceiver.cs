using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewZealand_Courier.Models
{
    public class CourierReceiver
    {
        [Key]
        public int Id { get; set; }
        //Name of the Receiver
        public string Receiver_Name { get; set; }
        //Address of the Receiver
        public string Receiver_Address { get; set; }
        //Contact number of the Receiver
        public string Receiver_Contact { get; set; }
        public Decimal Barcode { get; set; }
        //Foreign Key
        //public int CourierOfficeID { get; set; }
        //public CourierOffice CourierOffice_obj { get; set; }
        //Foreign Key
        //public int CourierDeliveryID { get; set; }
        //public CourierDeliver CourierDeliver { get; set; }
    }
}
