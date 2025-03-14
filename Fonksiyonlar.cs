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
    //-----------------int için----------------------//
    public static int MultiplyNumbers(int number1, int number2){
        return number1 * number2;
    }
    //-----------------double için --------------------//
    public static double MultiplyNumbers(double number1, double number2){
        return number1 * number2;
    }


    public static string ReverseWord(string word){
        char[] charArray = word.ToCharArray(); // kelimeyi harflerine bölüyor
        Array.Reverse(charArray); // harfleri ters çeviriyor
        return new string(charArray);
    }
}