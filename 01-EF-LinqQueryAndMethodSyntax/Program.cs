// Veri
// Linq : Sorgulamak
// EF

using _01_EF_LinqQueryAndMethodSyntax;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Linq sorgu (Query) sözdizimi ile fitreleme

// Filter
#region 2ye eşit olanlar
//IEnumerable<int> equalToTwo = from number in numbers   // numbers kollaksyionu içerisinde sorgulama yapılacak
//                              where number == 2        // kolaksiyon içinde 2 değerine eşit olanları filtreleyecek
//                              select number;           // sorgunun  sonucunu döndürecek 


//foreach (int n in equalToTwo)
//{
//    Console.WriteLine(n);
//}

#endregion
#region evenNumbers

//IEnumerable<int> evenNumbers = from number in numbers   // numbers kollaksyionu içerisinde sorgulama yapılacak
//                              where number % 2 == 0        // kolleksiyon içinde çift sayıları filtreleyecek
//                              select number;           // sorgunun  sonucunu döndürecek 


//foreach (int n in evenNumbers)
//{
//    Console.WriteLine(n);
//} 
#endregion
#region biggerThan5

// 5 'ten büyük olanları liste
//var biggerThan5 = from n in numbers
//                  where n > 5
//                  select n; 
#endregion


// LINQ method sözdizimi ile filtreleme
#region 2'ye eşit olanlar

//IEnumerable<int> equalToTwo = numbers.Where(number => number == 2);

//foreach (int n in equalToTwo)
//{
//    Console.WriteLine(n);
//} 
#endregion

#region evenNumbers

//var evenNumbers = numbers.Where(n => n % 2 == 0);

//foreach (int n in evenNumbers)
//{
//    Console.WriteLine(n);
//}

#endregion

#region biggerThan5

// 5 'ten büyük olanları liste
var biggerThan5 = numbers.Where(x => x > 5);
#endregion

#region Order

// Sırlama (OrderBy, OrderByDescending)
//var sorted = numbers.OrderBy(x => x); // A-Z
//var sorted = numbers.OrderByDescending(x => x);  // Z-A

//foreach (var number in sorted)
//{
//    Console.WriteLine(number);
//}
#endregion

#region İlk Eleman (First, FirstOrDefault)

// İlk Eleman (First, FirstOrDefault)
//var first = numbers.Where(x => x % 2 == 0).First();
//var first = numbers.Where(x => x % 2 == 0).OrderByDescending(x => x).First();

//var first = numbers.Where(x => x == 5).FirstOrDefault();

//Console.WriteLine(first);
#endregion

#region  Toplama ve Aritmetik işlemler

//int toplam = numbers.Sum();
//Console.WriteLine(toplam);

//double avarage = numbers.Average();
//Console.WriteLine(avarage);

//int max = numbers.Max();
//int min = numbers.Min();
//Console.WriteLine(max);
//Console.WriteLine(min);

#endregion

#region Group

//var grup = numbers.GroupBy(x => x % 2 == 0 ? "çift" : "tek");

//foreach (var n in grup)
//{
//    Console.WriteLine(n.Key);

//    foreach (var x in n)
//    {
//        Console.WriteLine(x);
//    }
//}
#endregion


IList<Student> students = new List<Student>()
{
    new Student(){ StudentId = 1, Name = "Zafer", Age = 43 },
    new Student(){ StudentId = 2, Name = "İrem", Age = 23},
    new Student(){ StudentId = 3, Name = "Muhammed", Age = 19 },
    new Student(){ StudentId = 4, Name = "Ege", Age = 19 },
    new Student(){ StudentId = 5, Name = "Batuhan", Age = 26}
};


//var studentListesi = from s in students
//                     select s;

//foreach (var student in studentListesi)
//{
//    Console.WriteLine($"Adı : {student.Name} Id : {student.StudentId} Age: {student.Age}");
//}
// // Ödev verdim.

// Tüm listeyi ekrana bastırdım.
students.ToList().ForEach(x => Console.WriteLine($"{x.Name} {x.StudentId} {x.Age}"));

Console.WriteLine();

//students.Where(x => x.Name.Contains("a")).ToList().ForEach(x => Console.WriteLine($"{x.Name} {x.StudentId} {x.Age}"));

//Student student = students.First();
//Console.WriteLine(student.Name);

//Student? student = students.Where(x => x.StudentId == 10).FirstOrDefault();
//Console.WriteLine(student.Name);


//Student? student = students.LastOrDefault();
//Console.WriteLine(student.Name);

//students.Any(x => x.Name == "zafer");  // bool döner. 

//Student? student1 = students.Where(x => x.Age == 19).SingleOrDefault();
//Console.WriteLine(student1.Name);

//Console.WriteLine(students.Count());

//students.Reverse().ToList().ForEach(x => Console.WriteLine(x.Name));

IList<Student> studentListesi = students;
IEnumerable<Student> ters = students.Reverse();
List<Student> tersListe = students.Reverse().ToList();

var x = 5;
var y = 10.5;
var z = new Student();
var s = students;

//var silinecekStudunt = students.Where(x => x.Age == 19).First();

//students.Remove(silinecekStudunt);

//var silinecekStudents = students.Where(x => x.Age == 19);

//foreach (Student student in silinecekStudents)
//{
//    students.Remove(student);
//}

//students.ToList().ForEach(x => Console.WriteLine($"{x.Name} {x.StudentId} {x.Age}"));

//students.Where(x => x.Age == 19).ToList().ForEach(x => students.Remove(x));

//students.Skip(2).ToList().ForEach(x => Console.WriteLine(x.Name));

// 8 . sayfayı getir. her sayfada 50 ilan var. 7 * 50 = 350 tanseini atla.


students.Skip(2).Take(2).ToList().ForEach(x => Console.WriteLine(x.Name)); // ilk ikiyi atlar, sonraki ikiyi alır.



