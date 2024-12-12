using DesafioPOO.Models;
System.Console.WriteLine(" smatphone Iphone");
Iphone iphone = new Iphone("2111", "iphone@celular.com", "iphone 12 ", 120);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("github");
System.Console.WriteLine("--------------------------------------------");
System.Console.WriteLine(" smatphone Nokia");
Nokia nokia = new Nokia("2111", "Nokia@celular.com", "Nokia plus", 80);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("telegram");

