using Core.Utilities.results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Abstrac
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        
        //IDataResult <List<Product>> GetAllByCategoryId(int id);
        //IDataResult <List<Product>> GetByUnitPrice(decimal min, decimal max);
        IResult Add(Product product);

        IDataResult<Product> GetById(int ProductId);

    }
}
