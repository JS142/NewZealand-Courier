using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewZealand_Courier.Models;

namespace NewZealand_Courier.Data
{
    public class NewZealand_CourierContext : DbContext
    {
        public NewZealand_CourierContext (DbContextOptions<NewZealand_CourierContext> options)
            : base(options)
        {
        }

        public DbSet<NewZealand_Courier.Models.CourierOffice> CourierOffice { get; set; }

        public DbSet<NewZealand_Courier.Models.CourierDeliver> CourierDeliver { get; set; }

        public DbSet<NewZealand_Courier.Models.CourierReceiver> CourierReceiver { get; set; }

        public DbSet<NewZealand_Courier.Models.Vehicles> Vehicles { get; set; }
    }
}
