using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JwtDemo.DB
{
    public class Factory
    {
      public void CC()
        {
            //new  ChargeDbContext().get
           //new ChargeDbContext().Stations.
        }
    }

    public class ChargeDbContext : DbContext
    {
        public DbSet<ChargeStation> Stations { get; set; }
  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            var conn = configuration.GetConnectionString("BizDatabase");
            //optionsBuilder.sq
            //optionsBuilder.usesql(conn);
        }
    }

    /// <summary>
    /// 充电站
    /// </summary>
    [Table("Stations")]
    public class ChargeStation
    {
        [Key]
        [Column("ID")]
        public string ID { get; set; }

        [Required]
        [Column("Code")]
        public string Code { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Column("MaintainTel")]
        public long MaintainTel { get; set; }

        //[ForeignKey("StationID")]
        //public virtual List<ChargeStationController> Controllers { get; set; }
    }
}
