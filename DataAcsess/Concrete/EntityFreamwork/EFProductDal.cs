using Core.DataAcsess.EntityFreamwork;
using DataAcsess.abstrac;
using Entities.Concrete;
using Entities.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsess.Concrete.EntityFreamwork
{
    public class EFProductDal : EfEntityRepositoryBase<Product, Northwind>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
