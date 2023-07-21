using DataAcsess.abstrac;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsess.Concrete.EntityFreamwork
{
    public class EFProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (Northwind context=new Northwind())
            {
                var addedentity = context.Entry(entity);  
                addedentity.State=EntityState.Added;
                context.SaveChanges();
            
            }
        }

        public void Delete(Product entity)
        {
            using (Northwind context = new Northwind())
            {
                var deletedentity = context.Entry(entity);
                deletedentity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (Northwind context=new Northwind())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter )
        {
            using (Northwind context=new Northwind())
            {
                return filter == null ? context.Set<Product>().ToList():
                    context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (Northwind context = new Northwind())
            {
                var uptadedentity = context.Entry(entity);
                uptadedentity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
