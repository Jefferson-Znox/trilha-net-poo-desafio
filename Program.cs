using DesafioPOO.Models;

// TODO: Testes realizado com sucesso nas classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "N1", imei: "1122334455", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "98765321", modelo: "I1", imei: "5544332211", memoria: 248);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");