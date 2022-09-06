NewMethod();
static void NewMethod()
{

    

    int i = 0;  

    while (i<3)
    {
        Console.WriteLine("Siseestage palun kasutajatunnus:");
        string userName = Console.ReadLine();
        Console.WriteLine("Sisestage parool:");
        string password = Console.ReadLine();
        if (userName == "tudeng" && password == "1234")
            {
            Console.WriteLine(" Tere tulemast");
            break; 
        }
        
       
        else 
        {
            i = i + 1;
            Console.WriteLine($"proovi uuesti. Teil on { 3 - i}  katset");
        }
         if (i == 3)
        {
            Console.WriteLine("palun pöörduge administraatori poole, teie konto on blokeeritud");

        }
    }
}   
