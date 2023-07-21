using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsess.Concrete.EntityFreamwork
{
    public class Northwind:DbContext
    {
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=LAPTOP-R3KJC1J9\SQLEXPRESS02;Database=Northwind;Trusted_Connection=true ");
        }
        public DbSet<Product> Products { get  ; set ; }


    }
}
