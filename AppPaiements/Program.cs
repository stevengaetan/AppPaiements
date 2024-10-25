using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit CarteCredit12 = new CarteCredit(200, "BIEN", 1234);
        CarteCredit CarteCredit14 = new CarteCredit(300, "BIEN", 3456);
        CarteCredit CarteCredit16 = new CarteCredit(100, "GREAT", 2349);

        CarteCredit12.AfficherDetails();
        CarteCredit14.AfficherDetails();
        CarteCredit16.AfficherDetails();


        Paypal PaieN1 = new Paypal(150, "Achat de Sparking Zero", "Songoku@dbz.com");
        Paypal PaieN2 = new Paypal(2000, "Achat de levono Legion i7", "Zach@gmail.com");

        PaieN1.AfficherDetails();
        PaieN2.AfficherDetails();
    }
}