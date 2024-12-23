using System;

class Program
{
    static void Main()
    {
        // API KEY formatında bir secret
        const string ApiKey = "sk_test_1234567890abcdef12345678"; // SECRET

        // Sabit şifre
     // WARNING: Hardcoded password, do not use in production
const string HardcodedPassword = "P@$$w0rd_Production123!";



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
