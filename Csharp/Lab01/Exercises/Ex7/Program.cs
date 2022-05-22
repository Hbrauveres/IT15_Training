double valFrac = 4.7;
int valInt1 = (int) valFrac;
int valInt2 = Convert.ToInt32(valFrac);

Console.WriteLine("Conversao explicita = " + valInt1);
Console.WriteLine("Conversao metodo Convert = " + valInt2);