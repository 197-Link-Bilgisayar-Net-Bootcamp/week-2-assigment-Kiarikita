
using Solid;
using Solid.DependencyInversion;
using Solid.LiskovSubstitution;

//ders örneği
Phone phone = new IPhone();

phone.Call();
((ITakePhoto)phone).TakePhoto();

phone = new Nokia();

phone.Call();
//phone.TakePhoto();

IProductRepository pr = new ProductRepository();

ProductService ps = new ProductService(pr);

Console.WriteLine(String.Join(".", ps.GetProductNames()));
