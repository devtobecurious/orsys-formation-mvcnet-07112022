using AllerAuTravail;

IMeteo meteo = new ApiMeteoFrance();
IRegleDeplacement regle = new BaseSurMeteoRegleDeplacement(meteo);
IRegleDeplacement regleParente = new RegleBaseSurDeuxRegleDeplacement(regle, regle);

var salarie = new Salarie(regleParente);
salarie.AllerAuTravail();
