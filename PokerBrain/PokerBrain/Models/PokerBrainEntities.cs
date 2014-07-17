using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PokerBrain.Models
{
    public class PokerBrainEntities : DbContext
    {
        public PokerBrainEntities()
            : base("PokerBrainEntities")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}