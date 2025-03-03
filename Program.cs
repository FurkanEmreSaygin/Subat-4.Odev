using System;


class Program{
    
    static void Main(){

        //----------------------------- Bir listenin içindeki tek sayıları filtreleyen bir Lambda fonksiyonu yaz.-------------------//
        /*

        List<int> Numbers = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 511, 86, 98, 65, 55, 353, 3253}; // Kafamdan bir liste attım

        Console.WriteLine("All numbers: "+ string.Join(", ",Numbers));
        
        List<int> OddNumbers = Numbers.Where(number => number %2 != 0).ToList(); // sayılar 2 ye böldüm. 2 ye tam bölünüyorsa çifttir bu yüzden olmayan olarak değiştirdim.

        Console.WriteLine("");
        Console.WriteLine("Odd Numbers: " + string.Join(", ",OddNumbers));

        */      
        
        // ---------------------------- Func kullanarak iki string’i birleştiren bir metot oluştur. ----------------//
        
        Func<string, string, string> Combine = (str1, str2) => str1 + " " + str2;

        string Combined = Combine("Furkan Emre", "Saygın");

        Console.WriteLine($"Hello {Combined}");
    }
}