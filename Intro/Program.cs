// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

#region Temel Konseptler

//variables --> camelCase
//Metinsel veri türü : string
string message = "Krediler";
string message1 = "Krediler";
string message2 = "Krediler";
string message3 = "Krediler";

//Sayısal (tamsayı) veri türü : int
int term = 12;

//Sayısal (ondalıklı) veri türü : int
double amount = 10000.5;

//Mantıksal (doğru/yanlış) veri türü : boolean
bool isAuthenticated = true;

Console.WriteLine(message);

//condition
//if sorgusundan sonra süslü parantez kullanmadan bir kod satırı yazılırsa sadece ardından gelen tek satırı sorguya göre işleme alır.
if (isAuthenticated == true)    //veya (isAuthenticated) olarak yazılabilir
{
    Console.WriteLine("Button --> Hoşgeldin Batuhan.");
}
else
{
    Console.WriteLine("Button --> Sisteme Giriş Yap");
}

//Döngüler / Array - List
string[] loans = new string[] { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5" };

//string[] loans2 = new string[5];
//loans2[0] = "kredi 1";

//parametreler sırasıyla : start (başlangıç değeri) - condition (şu koşul olana dek çalışmaya devam et) - increment : artış miktarı
for (int i = 0; i < loans.Length; i++)
{ Console.WriteLine(loans[i]); }

Console.WriteLine("Kod bitti!");

#endregion

#region Nesne Yapısı - OOP
#region Nesne tutucu sınıflar
//instance = referans oluşturmak
Course course1 = new Course();
course1.Id = 1;
course1.Name = "Yazılım Geliştirici Yetiştirme Kampı 2024";
course1.Description = ".NET 8 kullanılarak C# dilinde, baştan sona yazılım geliştirici yetiştirme kampıdır.";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 1;
course2.Name = "Java Geliştirme Kampı";
course2.Description = "Java yazılım dilinde baştan sona eğitim kampıdır.";
course2.Price = 10;

Course[] courses = new Course[] { course1, course2 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}
#endregion

#region Operasyon tutucu sınıflar
CourseManager courseManager = new CourseManager();
Course[] returnCourses = courseManager.GetAll(); //Method - Operasyon
for (int i = 0;i < returnCourses.Length;i++)
{
    Console.WriteLine(returnCourses[i].Name);
}
#endregion
#endregion