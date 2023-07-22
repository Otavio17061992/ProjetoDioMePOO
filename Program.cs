using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("N95" , "MG3090" , "11922128129" , 256);


nokia.Ligar();

nokia.InstalarAplicativo("whatsApp");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Smartphone Iphone: ");
Iphone iphone12 = new Iphone("iphone 12 mini" , "Ge22s" , "11125448856" , 512);

iphone12.Ligar();

iphone12.ReceberLigacao();


