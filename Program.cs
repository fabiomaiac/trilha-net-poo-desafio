using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123", modelo: "G90", imei: "123456", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("-----------------------------------------------");

Console.WriteLine("Smartphone iPhone");
Smartphone Iphone = new Iphone(numero: "456", modelo: "14", imei: "25900", memoria: 256);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Telegram");



// TODO: Realizar os testes com as classes Nokia e Iphone