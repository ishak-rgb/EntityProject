using Busines.Concrete;
using Core.Utilities.results;
using DataAcsess.Concrete.EntityFreamwork;


//{
//    ProductTest();
//    CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
//    foreach (var category in categoryManager.GetAll())
//    {
//        Console.WriteLine(category.CategoryName);
//    }
//    Console.ReadLine();

//}
//static void ProductTest()
//{
//    ProductManager productManager = new ProductManager(new EFProductDal());
//    foreach (var item in productManager.GetByUnitPrice(100, 1000))
//    {
//        Console.WriteLine(item.ProductName);
//    }
//}

ProductManager productManager = new ProductManager(new EFProductDal());
foreach (var item in productManager.GetAll().Data)
{
    Console.WriteLine(item.ProductName);
}
Console.ReadLine();





