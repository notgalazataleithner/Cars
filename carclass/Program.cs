using Gitt;

namespace Program
{
    class Program
    {
        static void Main()
        {
            car  Vw = new car("White", 90,55,100,30,50);
            Console.WriteLine($"Das Auto hat die Farbe {Vw.Farbe } und eine Leistung von {Vw.Leistung } PS");
            Vw.Beschleunigen();

            car Bratus = new car("Blue", 300, 100, 300, 80, 60); 
            Console.WriteLine($"Der Bratus hat die Farbe {Bratus.Farbe} und hat eine Leistung von {Bratus.Leistung} PS");
            Bratus.Beschleunigen();
            Bratus.Bremsen();
            Bratus.Kraftstofftank = 60;
            Bratus.Geschwindigkeit = 150;
            Bratus.Fahren();


        }
    }
        
}