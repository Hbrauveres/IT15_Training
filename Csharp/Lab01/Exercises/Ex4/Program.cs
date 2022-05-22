int i = 10;
float f;
f = i; // Conversão implicita
Console.WriteLine($"{f} -> {f.GetType()}");

f = 0.5f;
i = (int)f; // Conversão Explicita
Console.WriteLine($"{i} -> {i.GetType()}");

Console.WriteLine("int - " + typeof(int).ToString());
Console.WriteLine("long - " + typeof(long).ToString());
Console.WriteLine("float - " + typeof(float).ToString());
Console.WriteLine("double - " + typeof(double).ToString());
Console.WriteLine("decimal - " + typeof(decimal).ToString());
Console.WriteLine("byte - " + typeof(byte).ToString());
Console.WriteLine("string - " + typeof(string).ToString());