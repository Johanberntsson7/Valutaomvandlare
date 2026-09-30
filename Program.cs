namespace Valutaomvandlare;

class Program
{
    static void Main(string[] args)
    {

//         Skapa en konsolapplikation som konverterar en summa pengar från en valuta till en annan. Inkludera typkonverteringar, operatörer och kontrollflöde.
        
// Instruktioner:
// Be användaren att ange en summa pengar i SEK.
        Console.WriteLine("Välkommen till Johans bank");

        Console.WriteLine("Skriv in en summa pengar i SEK");
        decimal number = decimal.Parse(Console.ReadLine()!);

// Ange en lista över tillgängliga valutor (t.ex. EUR, GBP, JPY,USD).
        List<string> valutor = new List<string> { "EUR", "GBP", "JPY", "USD", "CZK"};

        Console.WriteLine("Välj valuta: EUR, GBP, JPY USD eller CZK");
        string valuta = (Console.ReadLine()!).ToUpper();

    
// Använd en switch-sats för att hantera valutaomvandlingen.
        decimal omvandlatBelopp;
        switch (valuta)
        {
            case "EUR":
                omvandlatBelopp = number * 0.092m;
                break;
            case "GBP":
                omvandlatBelopp = number * 0.079m;
                break;
            case "JPY":
                omvandlatBelopp = number * 15.7m;
                break;
            case "USD":
                omvandlatBelopp = number * 0.099m;
                break;
            case "CZK":
                omvandlatBelopp = number * 2.18m;
                break;    

            default:
                Console.WriteLine("Ogiltig valuta.");
                return;
        }

        
// Utför omvandlingen med multiplikationsoperatorer och skriv gjutning vid behov.
// Visa det konverterade beloppet.
        Console.WriteLine($"{number} SEK = {omvandlatBelopp:F2} {valuta}");


        Console.ReadLine();
    }

}
