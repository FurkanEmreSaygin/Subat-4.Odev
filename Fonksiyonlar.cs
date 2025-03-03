public class Fonksiyonlar { 
    
    public static void ikikati(ref int Number){
        Number *= 2; 
    }
    
    public static int Topla(params int[] sayilar){
        int toplam = 0;
        foreach (int sayi in sayilar){
            toplam += sayi;  // Her sayıyı toplama ekle
        }
        return toplam;
    }
    public static void GreetUser(string name){
        Console.WriteLine($"Merhaba, {name}! Hoş geldiniz.");
    }

}