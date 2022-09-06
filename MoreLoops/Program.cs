NewMethod();
static void NewMethod()
{
        
            //programm palub kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis kuvab konsool "Tere tulemast!"
            //muul juhul kuvab konsool "Vale kasutajatunnus või salasõna! Proovi uuesti!"

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            //AND (&&)

            if (userName == "tudeng" && userPassword == "pas1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või parool! Proovi uuesti!");
            }
        
    
}
