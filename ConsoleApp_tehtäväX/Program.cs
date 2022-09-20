bool jatketaan = false;
double numero1 = 0;
double numero2 = 0;
double vastaus = 0;
bool Yhteenlasku = false;
bool Kertolasku = false;
bool Jakolasku = false; 
do
{
    Console.WriteLine("Yhteenlasku ");
    Console.WriteLine("Kertolasku ");
    Console.WriteLine("Jakolasku ");
    Console.WriteLine("Valitse laskutoimitus");
    string laskutoimitus = Console.ReadLine();

    if (laskutoimitus == "Yhteenlasku")
    {
        Yhteenlasku = true;
    }
    else if (laskutoimitus == "Kertolasku")
    {
        Kertolasku = true;
    }
    else 
    {
        Jakolasku = true;   
    }

    if(Yhteenlasku == true)
    {
        Console.WriteLine("Valitsit: {0}", laskutoimitus);
        Console.WriteLine("Anna Laskettava numero 1: ");
        string annettu = Console.ReadLine();
        while(!double.TryParse(annettu, out numero1))
        {
            Console.WriteLine("Yritä vielä kerran");
            annettu = Console.ReadLine();
        }
       
          Console.WriteLine("Anna laskettava numero 2: ");
        annettu = Console.ReadLine();
             while (!double.TryParse(annettu, out numero2))
               {
                Console.WriteLine("Yritä vielä");
                annettu = Console.ReadLine();
             };
        //Laskutoimitus
         vastaus = numero1 + numero2;
        Console.WriteLine("Vastauksesi on: {0}", vastaus);

    }
    else if (Kertolasku == true) 
    {
        Console.WriteLine("Valitsit: {0}", laskutoimitus);
        Console.WriteLine("Anna Laskettava numero 1: ");
        string annettu = Console.ReadLine();
        while (!double.TryParse(annettu, out numero1))
        {
            Console.WriteLine("Yritä vielä kerran");
            annettu = Console.ReadLine();
        }

        Console.WriteLine("Anna laskettava numero 2: ");
        annettu = Console.ReadLine();
        while (!double.TryParse(annettu, out numero2))
        {
            Console.WriteLine("Yritä vielä");
            annettu = Console.ReadLine();
        };
        //Laskutoimitus
        vastaus = numero1 * numero2;
        Console.WriteLine("Vastauksesi on: {0}", vastaus);
    }
    else if (Jakolasku == true)  
    {
        Console.WriteLine("Valitsit: {0}", laskutoimitus);
        Console.WriteLine("Anna Laskettava numero 1: ");
        string annettu = Console.ReadLine();
        while (!double.TryParse(annettu, out numero1))
        {
            Console.WriteLine("Yritä vielä kerran");
            annettu = Console.ReadLine();
        }

        Console.WriteLine("Anna laskettava numero 2: ");
        annettu = Console.ReadLine();
        while (!double.TryParse(annettu, out numero2))
        {
            Console.WriteLine("Yritä vielä");
            annettu = Console.ReadLine();
        };
        //Laskutoimitus
        vastaus = numero1 / numero2;
        Console.WriteLine("Vastauksesi on: {0}", vastaus);
    }

    Console.Write("Lisää numeroita (K/E)?");
    string valinta = Console.ReadLine().ToUpper();
    if (valinta.StartsWith("K"))
        jatketaan = true;
    else
        jatketaan = false;
} while (jatketaan);
