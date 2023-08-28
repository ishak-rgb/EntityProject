using Core.DataAcsess.EntityFreamwork;
using DataAcsess.abstrac;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsess.Concrete.EntityFreamwork
{
    public class EFOrderDal : EfEntityRepositoryBase<Order, Northwind>, IOrderDal
    {

        

    }
}
