// See https://aka.ms/new-console-template for more information

using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Smartphone nokia = new Nokia("3499999999", "Nokia G21", "111111111111", 64);
        Console.WriteLine("=== NOKIA ===");
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        Smartphone iphone = new Iphone("1199999999", "iPhone 13", "222222222222", 128);
        Console.WriteLine("=== IPHONE ===");
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }
}
