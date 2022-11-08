using CRM.Libs;

// Découverte utilisation delegué
AfficherMonInfo monInfo = Console.WriteLine;
Action<string> monInfoBis = Console.WriteLine;
Action<int> monInfoCis = Console.WriteLine;
// monInfoBis = monInfo; Ce sont deux types différents malgré tout



monInfo("test");
monInfo("test");
monInfo.Invoke("Test");


float getTva20Pourcent()
{
    // Appeler une api json qui fait le boulot
    return 1.2f;
}

float getTva55Pourcent()
{
    return 1.055f;
}

// Appel du calculateur
Calculateur calc = new Calculateur();
var montantTTC = calc.CalculerTva(20,
                                  getTva20Pourcent,
                                  Console.WriteLine);

//AfficherMonInfo maFonctionDaffichageEnMajusculeSansNom = (string mess) =>
//{
//    Console.WriteLine(mess.ToUpper());
//};

//AfficherMonInfo maFonctionDaffichageEnMajusculeSansNom = mess =>
//{
//    Console.WriteLine(mess.ToUpper());
//};

AfficherMonInfo maFonctionDaffichageEnMajusculeSansNom = mess => Console.WriteLine(mess.ToUpper());


montantTTC = calc.CalculerTva(20,
                              getTva20Pourcent,
                              maFonctionDaffichageEnMajusculeSansNom);

montantTTC = calc.CalculerTva(20,
                              getTva20Pourcent,
                              mess => Console.WriteLine(mess.ToUpper())
                             );

void AfficherEnRouge(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}

montantTTC = calc.CalculerTva(20, getTva55Pourcent, AfficherEnRouge);




