using _04_EF_Inheritance.Contexts;
using _04_EF_Inheritance.Entities;

Console.WriteLine("Hello, World!");


// 3 tane employee ekle
// 3 customer ekle

AppDbContext ctx = new AppDbContext();

//ctx.Employees.Add(new Employee() { Name = "Ali", BirthDate = new DateTime(2000, 5, 6), JobDescription = "IT", AdmissionDate = new DateTime(2024, 5, 4) });

//ctx.Customers.Add(new Customer() { Name = "Teknosa", LastPurchaseDate = DateTime.Now.AddDays(-10), TotalVisit = 100 });

//ctx.SaveChanges();

Employee employee = new Employee() { Name = "Ali", BirthDate = new DateTime(2000, 5, 6), JobDescription = "IT", AdmissionDate = new DateTime(2024, 5, 4) };

Customer customer = new Customer() { Name = "Teknosa", LastPurchaseDate = DateTime.Now.AddDays(-10), TotalVisit = 100 };

ctx.People.Add(employee);
ctx.People.Add(customer);

ctx.SaveChanges();
