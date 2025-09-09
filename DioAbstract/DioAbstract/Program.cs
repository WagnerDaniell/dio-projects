using DioAbstract.Models;

Console.WriteLine("Celular Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatApp");

Console.WriteLine("/n");

Console.WriteLine("Celular Iphone");
Smartphone iphone = new Iphone(numero: "23478", modelo: "Modelo 2", imei: "222222", memoria: 16);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
