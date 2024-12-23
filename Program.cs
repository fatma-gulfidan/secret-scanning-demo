using System;

class Program
{
    static void Main()
    {
        // SABİT ŞİFRE (BU SADECE DEMO AMAÇLIDIR!)
        const string HardcodedPassword = "DemoSecret123"; // SECRET

        Console.WriteLine("Şifreyi girin:");
        string userInput = Console.ReadLine();

        if (userInput == HardcodedPassword)
        {
            Console.WriteLine("Doğru şifre! Giriş başarılı.");
        }
        else
        {
            Console.WriteLine("Hatalı şifre. Tekrar deneyin.");
        }
    }
}
