using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    //Global değişken tanımlama
    Course[] courses = new Course[3];

    /// <summary>
    /// Constructor method: Sınıftan bir instance üretildiği zaman nesne ayağa kaldırılırken işleyecek kodların yer aldığı yapıcı blok.
    /// </summary>
    public CourseManager()
    {
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

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Python Yazılım Kampı";
        course3.Description = "Yazılıma başlangıç seviyesinde Python eğitim kampıdır.";
        course3.Price = 20;

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }

    public Course[] GetAll()
    {
        //Veri kaynağından veriler çekilir.
        return courses;
        Console.WriteLine("Kurslar listelendi!");
    }
}
