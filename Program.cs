using System;


class Program{
    /*
    class Student{
        public string Name { get; set; }
        public int Age { get; set; }
    }
    */
class Logger
{
    private readonly string _filePath;

    // Constructor: Dosya yolunu ayarlıyor.
    public Logger(string filePath)
    {
        _filePath = filePath;
    }

    // Log mesajını dosyaya yazan yöntem.
    public void Log(string message)
    {
        try
        {
            // Mesajı dosyaya ekler, dosya yoksa oluşturur.
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Log yazılırken bir hata oluştu: {ex.Message}");
        }
    }
}

    
    static void Main(){
        
        //----------------------------- Bir listenin içindeki tek sayıları filtreleyen bir Lambda fonksiyonu yaz.-------------------//
 
        /*
        List<int> Numbers = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 511, 86, 98, 65, 55, 353, 3253}; // Kafamdan bir liste attım

        Console.WriteLine("All numbers: "+ string.Join(", ",Numbers));
        
        var OddNumbers = Numbers.Where(number => number %2 != 0).ToList(); // sayılar 2 ye böldüm. 2 ye tam bölünüyorsa çifttir bu yüzden olmayan olarak değiştirdim.

        Console.WriteLine("");
        Console.WriteLine("Odd Numbers: " + string.Join(", ",OddNumbers));
        */
        
        // ---------------------------- Func kullanarak iki string’i birleştiren bir metot oluştur. ----------------//
        
        /*
        Func<string, string, string> Combine = (str1, str2) => str1 + " " + str2;

        string Combined = Combine("Furkan Emre", "Saygın");

        Console.WriteLine($"Hello {Combined}");
        */

        // ----------------------------- Action kullanarak ekrana “Veri Kaydedildi” mesajını yazdır. ---------------//
        /*
        Action DataSaved = () => Console.WriteLine("Data Saved");

        DataSaved();
        */

        // ------------------Predicate kullanarak bir kelimenin 5 harften uzun olup olmadığını kontrol eden bir metot yaz. ---------------//
        /*
        Predicate<string> IsItlong = Word => Word.Length > 5;
        
        Console.Write("Enter Your Word: ");
        String Entery = Console.ReadLine();

        Console.WriteLine($"Is your entery longer than 5 letter? : {IsItlong(Entery)}");
        */
        
        // ------------------Gerçek dünya örneği: Bir öğrenci listesi oluştur ve 18 yaşından büyük olanları filtrele.  ---------------//
        /*
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
        */
        // ------------------Bir metot oluştur ve ref ile bir değişkenin değerini 2 katına çıkar.  ---------------//
        /*        
        Console.Write("Pls Enter a Number: ");
        int EntNumber = Convert.ToInt32(Console.ReadLine());

        Fonksiyonlar.ikikati(ref EntNumber);

        Console.WriteLine($"Your doubled number is: " + EntNumber);
        */
        // ------------------params kullanarak 5 farklı sayıyı toplayan bir metot yaz.   ---------------//
        
        /*
        int sonuc = Fonksiyonlar.Topla(5, 10, 15, 20, 25);

        Console.WriteLine("Toplam: " + sonuc);
        */
        
        // ------------------ Kullanıcıdan isim alıp selam veren bir metot yaz. ---------------//
        /*
        Console.Write("Lütfen adınızı girin: ");
        string name = Console.ReadLine();

        Fonksiyonlar.GreetUser(name);
        */

        // ------------------ KKullanıcıdan iki sayı alıp çarpan bir metot yaz. ---------------//
        /*
        Console.Write("Enter the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int result = Fonksiyonlar.MultiplyNumbers(firstNumber, secondNumber);

        Console.WriteLine($"The product is: {result}");
        */

        // ------------------ Aynı işlemi int ve double için yapan Overloading metodunu yaz. ---------------//
        /*
        Console.Write("Enter the first int number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second int number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int result = Fonksiyonlar.MultiplyNumbers(firstNumber, secondNumber);

        Console.WriteLine($"The product is: {result}");

        
        Console.Write("Enter the first double number: ");
        double double1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second double number: ");
        double double2 = Convert.ToDouble(Console.ReadLine());

        double result2 = Fonksiyonlar.MultiplyNumbers(double1, double2);

        Console.WriteLine($"The product is: {result2}");
        */
        // ------------------ Girilen bir kelimeyi tersten yazan bir metot yaz.  ---------------//
        /*
        Console.Write("Lütfen bir kelime girin: ");
        string cümle = Console.ReadLine();

        string reversed = Fonksiyonlar.ReverseWord(cümle);
        Console.WriteLine($"Kelimenin tersten yazılışı: {reversed}");
        */

        // ------------------ Kendi Logger sistemini yaz ve dosyaya log kaydet.  ---------------//

        Logger logger = new Logger("log.txt");
        logger.Log("Bu bir bilgi mesajıdır.");
        logger.Log("Bir hata oluştu.");
        Console.WriteLine("Mesajlar log dosyasına yazıldı.");
           
    }
}