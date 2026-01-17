using DesafioPOO.Models;

Console.WriteLine();
Console.WriteLine("=== Desafio Celular POO ===");
Console.WriteLine("=-= Testando o Smartphone Nokia =-=");
Console.WriteLine();

var nokia = new Nokia("123456789", "Nokia 3310", "000000000000001", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

Console.WriteLine();
Console.WriteLine("=== Desafio Celular POO ===");
Console.WriteLine("=-= Testando o Smartphone Iphone =-=");
Console.WriteLine();

var iphone = new Iphone("987654321", "iPhone 13", "000000000000002", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Snake");