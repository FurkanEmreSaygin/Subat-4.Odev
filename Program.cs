using System;
using System.Threading.Tasks;

class Program{
    
    public static async Task LongTermOperating(){

        Console.WriteLine("3 second countdown started");
        await Task.Delay(3000);
        Console.WriteLine("3 second is done !!!");
    
    }
    
    
    static async Task Main(){
        
        Console.WriteLine("Program Starting");
        
        await LongTermOperating();
        
        Console.WriteLine("Program Ended");

    }

}