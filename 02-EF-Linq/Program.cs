//Student nesnelerini içeren bir liste.

List<Student> students = new List<Student>
{
    new Student { Id=1, Name="Ahmet", Age=20, City="İstanbul", DepartmentId=101 },
    new Student { Id=2, Name="Mehmet", Age=22, City="Ankara", DepartmentId=101 },
    new Student { Id=3, Name="Ayşe", Age=19, City="İzmir", DepartmentId=102 },
    new Student { Id=4, Name="Fatma", Age=21, City="İstanbul", DepartmentId=102 },
    new Student { Id=5, Name="Fatih", Age=21, City="İstanbul", DepartmentId=101 }
};

//students.Add(new Student { Id = 5, Name = "Fatih", Age = 21, City = "İstanbul", DepartmentId = 101 });

List<Department> departments = new List<Department>()
{
    new Department { Id=101, Name="Bilgisayar Mühendisliği"},
    new Department { Id=102, Name="Elektirik Mühendisliği"},
    new Department { Id=103, Name="Makine Mühendisliği"}
};

students.ToList().ForEach(hamide => Console.WriteLine(hamide.Name + " " + hamide.Age));
departments.ToList().ForEach(hamide => Console.WriteLine(hamide.Name));

//students.Where(student => student.Id == 3);

students.Where(s => s.City == "İstanbul" && s.DepartmentId == 101).OrderBy(x => x.Name).ThenBy(x => x.Age); // Aynı isme sahip olanları yaşlarına göre artan sıralama

// Join Method Based

var newResult = students.             // Outer
                Join(departments,    // inner 
                s => s.DepartmentId,  // Outerkey 
                d => d.Id,            // innerKey 
                (s, d) => new { SName2 = s.Name, SAge2 = s.Age, DName2 = d.Name }).ToList(); // Result

foreach (var item in newResult)
{
    Console.WriteLine($"{item.SName2} {item.SAge2} {item.DName2}");
}

// Query Based
// SQL: Select Id = s.Id, Name = s.Name, Bolum = d.Name
//      from students as s
//      join departments as s
//      on s.DepartmentId = s.Id

var queryData = from s in students
                join d in departments
                on s.DepartmentId equals d.Id
                select new { Id = s.Id, Name = s.Name, Bolum = d.Name };

