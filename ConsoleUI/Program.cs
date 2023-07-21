using Busines.Concrete;
using DataAcsess.Concrete.EntityFreamwork;

ProductManager productManager = new ProductManager(new EFProductDal());
foreach (var item in productManager.GetByUnitPrice(100,1000))
{
    Console.WriteLine(item.ProductName);
}
Console.ReadLine();

    