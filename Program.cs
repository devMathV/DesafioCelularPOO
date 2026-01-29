using DesafioTelefone.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(99999, "Modelo 1", "1212121212", 64);
nokia.MostrarDadosDoTelefone();
nokia.Ligar();
nokia.InstalarAplicativo("Reddit");

Console.WriteLine("------------------------------");

Console.WriteLine("Smartphone Nokia:");
Smartphone iphone = new Iphone(88888, "Modelo 2", "2121212121", 128);
iphone.MostrarDadosDoTelefone();
iphone.Ligar();
iphone.InstalarAplicativo("Visual Studio Code");