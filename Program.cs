using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// FEITO11

Nokia celular1 = new Nokia("988665544","nokia 3200", "IMEI/MEID 0000123456", 12);
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("newAPP");


Iphone phone1 = new Iphone("988332211","iphone 15", "IMEI/MEID 0000659854", 24);
phone1.Ligar();
phone1.ReceberLigacao();
phone1.InstalarAplicativo("newAPP");
