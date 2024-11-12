/*
1 - Entity'leri yazarım 
2 - Entity'ler arasındaki ilişkileri kurarım.
3 - Microsoft.EntityFramework; Nuget PAckage Manager'dan bu doysa yüklenir
4- AppDbContext isminde bir sınıf oluşturup. DbContext sınıfından miras alıyorum.
5- AppDbContext sınıfında Ovveride OnConfiguring metodunu ovveride ediyoruz ve içine 

 optionsBuilder.UseSqlServer
("Server=.;Database=CodeFirst1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");

6 - UseSqlServer metodunu kullanabilmek için NPM'den Microsoft.EntityFrameworkCore.SqlServer indiriyoruz.
7- PMC (Package Manager Console) aç. Default Project benim migration yapmak istediğim proje ile aynı olacak 
8- PMC:Nuget / Install - Package Microsoft.EntityFrameworkCore.Tools - Version 8.0.10
9 - CTRL + Shift + B ile solution içindeki Error'ler varsa düzeltilecek.
10- PMC: PM > "add-migration ilk" yazıyoruz;
11 - PM > update - database
NuGet\Install - Package Microsoft.EntityFrameworkCore - Version 8.0.10
NuGet\Install-Package Microsoft.EntityFrameworkCore.SQLServer -Version 8.0.10
NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.10
 */
using _07_EF_LoadingType.Context;

#region Veri Girişi


//using (var _ctx = new AppDbContext())
//{
//    _ctx.Categories.Add(
//            new Category()
//            {
//                Name = "Elektronik",
//                Url = "",
//                Products = new List<Product>()
//                {
//                    new Product() {
//                        Name = "Laptop",
//                        Price = 15000,
//                        Stock = 55
//                    },
//                    new Product() {
//                        Name = "Mouse",
//                        Price = 1500,
//                        Stock = 50
//                    },
//                    new Product() {
//                        Name = "Klavye",
//                        Price = 500,
//                        Stock = 75
//                    }
//                }
//            }
//     );

//    _ctx.Categories.Add(
//           new Category()
//           {
//               Name = "Kitap",
//               Url = "",
//               Products = new List<Product>()
//               {
//                    new Product() {
//                        Name = "Benim Adım Kırmızı ",
//                        Price = 300,
//                        Stock = 255
//                    },
//                    new Product() {
//                        Name = "Savaşçı",
//                        Price = 500,
//                        Stock = 500
//                    },
//                    new Product() {
//                        Name = "Klavyenin Gücü",
//                        Price = 50,
//                        Stock = 750
//                    },
//               }
//           }
//    );
//    _ctx.SaveChanges();
//}

#endregion

//using (var _context = new AppDbContext())
//{
//    var joinedData = _context.Products.Join(
//        _context.Categories,
//        p => p.CategoryId,
//        c => c.Id,
//        (p, c) => new
//        {
//            Name = p.Name,
//            Price = p.Price,
//            Stock = p.Stock,
//            Category = c.Name
//        }
//        ).ToList();

//    Console.WriteLine();

//}

AppDbContext ctx = new AppDbContext();

//ctx.Products.ToList().ForEach(p => Console.WriteLine(p.Name));

//ctx.Products.ToList().ForEach(p => Console.WriteLine(p.Category.Name)); //System.NullReferenceException: 'Object reference not set to an instance of an object.'

//var product1 = ctx.Products.Include("Category");
//var product1 = ctx.Products.Include(p=> p.Category);

//foreach (var product in product1)
//{
//    Console.WriteLine(product.Category.Name);
//}

ctx.Products.ToList().ForEach(p => Console.WriteLine($"{p.Category.Name} {p.Name}"));