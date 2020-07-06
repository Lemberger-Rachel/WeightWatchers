using Microsoft.EntityFrameworkCore;
using Subscriber.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Subscriber.Services.Models
{
   public class WeightWatchersContext : DbContext
    {
        public WeightWatchersContext()
        {
                
        }
        public WeightWatchersContext(DbContextOptions<WeightWatchersContext> options)
          : base(options)
        {

        }
        public DbSet<SubscriberEntities> Subscribers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ILRLEMBERGERLT; Database= WeightWatchersDB; Trusted_Connection = True;MultipleActiveResultSets=true;");
            }
        }
    }
}
