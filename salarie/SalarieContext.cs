using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace salarie
{
    public class SalarieContext : DbContext
    {
        public SalarieContext() : base("Data Source =.; Initial Catalog = MaBaseSalarie1; Integrated Security = True")
        {
        }
        public DbSet<Salarie> Salaries { get; set; }
        public DbSet<Departement> Departements { get; set; }
    }
}