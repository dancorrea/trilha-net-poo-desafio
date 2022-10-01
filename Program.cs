using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("9988776655", "N95", "147852369", 64);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Snakes");

Console.WriteLine("----------------------------");

Console.WriteLine("iPhone");
Smartphone iphone = new Iphone("9988776655", "11 S Pro", "9846232679", 128);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Face Time");