using Busines.Abstrac;
using Busines.BusinessAspect.Autofac;
using Busines.Constants;
using Busines.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.results;
using DataAcsess.abstrac;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
                _productDal = productDal;
        }
        [SecuredOperation("product.list,admin")]
        [ValidationAspect(typeof(ProductValidater))]
        public IResult Add(Product product)
        {
            

           
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);

        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult <List <Product>>(_productDal.GetAll(),Messages.ProductListed);
        }

        public IDataResult<Product> GetById(int ProductId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p=>p.Id == ProductId));
        }

        //private IResult CheckIfProductNameExists(string productName)
        //{

        //    var result = _productDal.GetAll(p => p.ProductName == productName).Any();
        //    if (result)
        //    {
        //        return new ErrorResult(Messages.ProductNameAlreadyExists);
        //    }

        //    return new SuccessResult();
        //}





    }
}
