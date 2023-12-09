// See https://aka.ms/new-console-template for more information
string fraseDigitada, fraseComDislalia;
Console.WriteLine("Digite uma flase: ");
fraseDigitada = Console.ReadLine();

fraseComDislalia = fraseDigitada
.Replace("r", "l")
.Replace("R", "L");

Console.WriteLine(fraseComDislalia);
