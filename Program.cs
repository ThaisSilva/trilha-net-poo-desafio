
﻿using System.Globalization;
using System.Runtime;
using DesafioPOO.Models;

      
Console.WriteLine("Modelo Nokia:");
Smartphone nokia = new Nokia ("1234", "modelo x", "Imei 11111111", 128);
nokia.InstalarAplicativo("Instagram");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Modelo Iphone:");
Smartphone iphone = new Iphone("4321", "modelo w", "Imei 00000000", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");