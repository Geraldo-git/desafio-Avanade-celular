// See https://aka.ms/new-console-template for more information


using DesafioPOO.Models;

Nokia nokia = new Nokia("1111-2222", "Lumia", "01ab01235688", 8);
Iphone iphone = new Iphone("3333-4444", "Iphone 12", "01zx01185688", 8);

Console.WriteLine("================================================");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine("================================================");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
Console.WriteLine("================================================");