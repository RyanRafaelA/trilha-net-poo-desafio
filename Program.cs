using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("5767462", "3ª geração", "11111111111", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Netflix");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("98570978", "13 pro", "34554575", 120);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");