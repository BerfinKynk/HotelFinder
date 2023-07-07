using HotelFinderEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelFinderDataAccess
{
    public class HotelDbContext:DbContext
    {
       
            protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            {
                base.OnConfiguring(optionBuilder);
                optionBuilder.UseSqlServer("Server=DESKTOP-CDUQPOB; Trusted_Connection=True; TrustServerCertificate=True; Database=HotelDb; uid=sa; pwd=1234;");

            }
            public DbSet<Hotel> Hotels { get; set; }
     
       
    }
}
