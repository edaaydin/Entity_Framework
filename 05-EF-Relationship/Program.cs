
using _05_EF_Relationship.Context;
using _05_EF_Relationship.Entities;

Console.WriteLine("Hello, World!");

// Category: Id, Name
// Product : ProductId, Name, Stock, Price, Date
// ProductDetail: Color, Height, Width

// Navigation

AppDbContext ctx = new AppDbContext();

string categoryName = "Kırtasiye";

int categoryId;

if (!ctx.Categories.Any(c => c.Name == categoryName))
{
    ctx.Categories.Add(new Category() { Name = categoryName });    
}

categoryId = ctx.Categories.FirstOrDefault(c => c.Name == categoryName).CategoryId;

ctx.Products.Add(new Product()
{
    Name = "Kalem",
    Date = DateTime.Now,
    Price = 100,
    Stock = 23,
    CategoryRefId = categoryId,
    
    ProductDetail = new ProductDetail()
    {
        Color = "Mavi",
        Height = "20",
        Width = "2"
    }
});

// Bir kaç Kategori ekle. 
//Product eklerken, KategoriID yi bulun ve id ile ekleyin. ProductDetail bilgileri de eklensin.

ctx.SaveChanges();