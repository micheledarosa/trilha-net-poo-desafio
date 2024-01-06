using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia G60", imei: "351108334440464", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\nTestando Iphone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 15 Pro Max", imei: "356303489276616", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("iFood");