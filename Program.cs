using System;


class Program{
    class Student{
    public string Name { get; set; }
    public int Age { get; set; }
}
    
    static void Main(){

        List<Student> students = new List<Student>{ // Yeni list elemanları ekliyorum
            new Student { Name = "Ali", Age = 17 },
            new Student { Name = "Ayşe", Age = 19 },
            new Student { Name = "Mehmet", Age = 22 },
            new Student { Name = "Zeynep", Age = 16 },
            new Student { Name = "Can", Age = 20 },
            new Student { Name = "Furkan", Age = 5 },
            new Student { Name = "Emre", Age = 3 },
            
        };

        List<Student> AllStudent = students.ToList();   // listemdeki elemanları bir değişkene çekiyorum
        Console.WriteLine("");
        Console.WriteLine("All Students: ");

        foreach (var ogrenci in AllStudent){ // listedeki elemanları teker teker yazdırmak için döngü kurdum
            Console.WriteLine($"{ogrenci.Name}, {ogrenci.Age} years old");
        }

        List<Student> OlderThan18 = students.Where(o => o.Age > 18).ToList(); // Lambda fonksiyonu kurarak filtreleme yaptım
     
        Console.WriteLine("");
        Console.WriteLine("OLder than 18: ");

        foreach (var ogrenci in OlderThan18){  // listedeki elemanları teker teker yazdırmak için döngü kurdum
            Console.WriteLine($"{ogrenci.Name}, {ogrenci.Age} years old");
        }
    }
}