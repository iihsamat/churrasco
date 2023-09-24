//Stefeson

Console.Clear();

int adultosCalcool, adultoSalcool, criancas, adultos, pessoas;
double carne, acompanhamentos, cervejas, refrigerantes, agua;

Console.WriteLine("--- Churrasco ---");

Console.Write("Adultos (que ingerem bebidas alcoólicas): ");
adultosCalcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Adultos (que não ingerem bebidas alcoólicas): ");
adultoSalcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Crianças: ");
criancas = Convert.ToInt32(Console.ReadLine());

adultos = adultosCalcool + adultoSalcool;
pessoas = adultos + criancas;

carne = 0.4 * adultos + 0.2 * criancas;
acompanhamentos = 0.2 * pessoas;
cervejas = 2 * adultosCalcool;
refrigerantes = 0.5 * (adultoSalcool + criancas);
agua = 0.4 * pessoas;

Console.Clear();

Console.WriteLine("---- Listinha de coisas necessárias ----");

Console.WriteLine($"Carne(s): {carne:N1}kg");
Console.WriteLine($"Acompanhamentos: {acompanhamentos:N1}kg");
Console.WriteLine($"Cerveja(s): {cervejas:N1}L");
Console.WriteLine($"Refrigerante(s): {refrigerantes:N1}L");
Console.WriteLine($"Água: {agua:N1}L");

Console.WriteLine("----------------------------------------");