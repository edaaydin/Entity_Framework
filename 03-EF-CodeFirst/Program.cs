using _03_EF_CodeFirst;

/*
1- Entity'leri yazarım
2- Entity'ler arasındaki ilişkileri kurarım.
3- Microsoft.EntityFrameworkCore; Nuget Package Manager'dan bu dosya yüklenir.
4- AppDbContext isminde bir sınıf oluşturup. DbContext sınfıından miras alıyorum.
5- AppDbContext sınıfında override OnConfiguring metodunu override ediyoruz ve içine  optionsBuilder.UseSqlServer("Server=.;Database=Yzl5101-CodeFirst1;User Id=zdorter;Password=1q2w3e4r5t6y;"); yazıyoruz.
6- UseSqlServer metodunu kullanabilmek için NPM'den Microsoft.EntityFrameworkCore.SqlServer indiriyoruz.
7- PMC (Package Manager Console) aç. Default Project benim migration yapmak istediğim proje ile aynı olacak.
8- PMC: NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.10
9- CTRL + Shift + B ile solution içindeki Error'ler varsa düzeltilecek.
10- PMC: PM> "add-migration ilk" yazıyoruz.  
11- PM> update-database

NuGet\Install-Package Microsoft.EntityFrameworkCore -Version 8.0.10
NuGet\Install-Package Microsoft.EntityFrameworkCore.SQLServer -Version 8.0.10
NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.10

 */

AppDbContext context = new AppDbContext();

List<Author> liste = context.Authors.ToList(); // Select

foreach (var item in liste)
{
    Console.WriteLine($"{item.Id}\t{item.Name}\t{item.Surname}");
}
Console.WriteLine("");

//Id = 1 => Veritabanında 1 varken yaptık. InvalidOperationException: The instance of entity type 'Author' cannot be tracked because another instance with the same key value for {'Id'} is already being tracked. When attaching existing entities, ensure that only one entity instance with a given key value is attached. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see the conflicting key values.'

// Id = 3 => Microsoft.EntityFrameworkCore.DbUpdateException: SqlException: Cannot insert explicit value for identity column in table 'Authors' when IDENTITY_INSERT is set to OFF.
#region Insert

// Insert yapıyoruz.
//context.Authors.Add(new Author() { Name = "Batuhan", Surname = "Balta" });

//context.SaveChanges(); // SaveChanges yaptığımızda context te yaptığımız tüm değişiklikler veritabanına kaydedilir.

//foreach (var item in context.Authors.ToList())
//{
//    Console.WriteLine($"{item.Id}\t{item.Name}\t{item.Surname}");
//}

#endregion

#region Update
//Author? author = context.Authors.Find(3);

////Author? author = context.Authors.Find(6);
////System.NullReferenceException: 'Object reference not set to an instance of an object.'
//if (author is not null)
//{
//    author.Name = "Ege";
//    author.Surname = "Gacal";
//}

//context.SaveChanges(); // insert, update, delete işlemlerinden sonra çalıştırmamız gerekiyor. Çoklu işlem yapıyorsam sadece 1 defa en sonra yazarım.

#endregion

#region Sil

// Silinecek Entity'i bul
// Remove et
// SaveChanges();

//Author? author = context.Authors.Find(3);

//context.Authors.Remove(author);

//context.SaveChanges();

#endregion


#region 1-1 insert

//Author author = new Author()
//{
//    Name = "Eda",
//    Surname = "Aydın",
//    Profile = new Profile()
//    {
//        Email = "edaaydin@gmail.com",
//        DogumTarihi = new DateTime(2000, 5, 4)
//    }
//};

//context.Authors.Add(author);

//context.SaveChanges();

#endregion

#region 1-N insert

// Author ve Book

context.Authors.Add(
    new Author()
    {
        Name = "Zehra",
        Surname = "Dörter",
        Profile = new Profile()
                    {
                        Email = "zehra@gmail.com",
                        DogumTarihi = new DateTime(1986, 4, 7)
                    },
        Books = new List<Book>() 
                {
                    new Book() { Title = "Hoşgeldin Sincap Bebek", PageSize = 20 },
                    new Book() { Title = "Sincap Bebek Okula Başladı", PageSize = 25 }
                }
    }
);



//context.SaveChanges(); // Veritabanında değişiklikleri kalıcı yapamk için bunu kullanıyoruz.

#endregion
// System.NullReferenceException: 'Object reference not set to an instance of an object.'
foreach (Author author in context.Authors.ToList())
{
    Console.WriteLine($"{author.Id}\t{author.Name}\t{author.Surname}\t{author.Profile?.Email ?? "Email Boş"}");

    if (author.Books is not null)
    {
        foreach (var book in author.Books)
        {
            Console.WriteLine($"\t{book.Title}\t{book.PageSize}");
        }
    }
}


//context.Books.Add(
//    new Book()
//    {
//        Author = new Author() { Name = "Orhan", Surname = "Pamuk" },
//        Title = "Benim Adım Kırmızı",
//        PageSize = 400
//    }
//);

//Lazy Loading
var BooksWithAuthor = context.Books.Join(
                context.Authors,
                b => b.AuthorId,
                a => a.Id,
                (b,a) => new {Title = b.Title, PageSize = b.PageSize, FirstName = a.Name}
                ).ToList();

Console.WriteLine();

foreach (var item in BooksWithAuthor)
{
    Console.WriteLine($"Kitap Adı: {item.Title} Sayfa Sayısı:  {item.PageSize} Yazar Adı: {item.FirstName}");
}
