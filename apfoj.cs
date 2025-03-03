
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
        