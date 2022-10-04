using DesafioPOO.Models;

Smartphone nokia = new Nokia("31988888888", "Nokia", "11111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");
nokia.ReceberLigacao();
nokia.Numero = "31555555555";

Smartphone iphone = new Iphone("31777777777", "Iphone", "33333333333", 120);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
iphone.Numero = "31444444444";
iphone.Ligar();