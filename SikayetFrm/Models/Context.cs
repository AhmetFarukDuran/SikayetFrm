using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SikayetFrm.Models
{
    public class Context : DbContext
    {
        public DbSet<Kisiler> Kisilers { get; set; }
        public DbSet<Sikayetler> Sikayetlers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}