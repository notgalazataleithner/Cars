namespace Gitt;

public class car
{
    public string Farbe;
    public double Leistung;
    public double Geschwindigkeit { get; set; }
    public double Höchstgeschwindigkeit { get; set; }
    public double MaxTank { get; set; }
    public double Kraftstofftank { get; set; }
    
    
    public void Beschleunigen()
    {
        
        while (Geschwindigkeit <= Höchstgeschwindigkeit)
        {
            Geschwindigkeit += 10;
            Kraftstofftank -= 0.2;
            Console.WriteLine("Das Auto beschleunigt um 10km/h");
            Tankanzeige();
        }

        Console.WriteLine("Maximale Geschwindigkeit erreicht");
        Tankanzeige();
    }

    public void Bremsen()
    {
        while (Geschwindigkeit >= 0)
        {
            Geschwindigkeit -= 10;
            Kraftstofftank -= 0.05;
             Tankanzeige();
        }

        Geschwindigkeit = 0;
        Tankanzeige();

    }

    public void Vollbremsung()
    {
        Console.WriteLine("Vollbremsung voraus");
        Geschwindigkeit = 0;
    }

    public void Fahren()
    {
        while (Kraftstofftank > 0)
        {
            Kraftstofftank -= 0.1;
            Tankanzeige();
        }
        
    }

    private void Tanken()
    {
        Kraftstofftank = MaxTank;
        Console.WriteLine("Auf gehst nach Jerusalem");
    }

    private void Tankanzeige()
    {
        if (Kraftstofftank <= 0)
        {
            Kraftstofftank = 0;
            Console.WriteLine("Tankleer!!!!!!!!!!! ACHTUNG!!!!");
        }
        else if (Kraftstofftank <= MaxTank * 0.1)
        {
            Console.WriteLine("Achtung: Tank fast leer!");
        }
        else
        {
            Console.WriteLine($"Aktuller Stand: {Kraftstofftank}");
        }
    }

    public car(string farbe, double leistung, double geschwindigkeit, double höchstgeschwindigkeit, double maxTank,
        double kraftstofftank)
    {
        Farbe = farbe;
        Leistung = leistung;
        Geschwindigkeit = geschwindigkeit;
        Höchstgeschwindigkeit = höchstgeschwindigkeit;
        MaxTank = maxTank;
        Kraftstofftank = kraftstofftank;
    }

}