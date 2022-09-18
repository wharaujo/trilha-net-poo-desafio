using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone Nokia = new Nokia(numero: "9988-4523", modelo: "NK-5656", imei: "45KT568TRG4", memoria: 128);
Smartphone IphoneXr = new Iphone(numero: "98645-7451", modelo: "Iphone XR", imei: "F58FYH4568", memoria: 256);


Console.WriteLine("Smartphone Nokia NK-5656");
Nokia.Ligar();
Nokia.ReceberLigacao();
Nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone Xr");
IphoneXr.Ligar();
IphoneXr.ReceberLigacao();
IphoneXr.InstalarAplicativo("Facebook");