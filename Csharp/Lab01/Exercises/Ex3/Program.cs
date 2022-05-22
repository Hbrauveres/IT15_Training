
double[] hours = {.08333, .16667, .25, .33333, .5, .66667, 1, 2, 29, 30, 31, 90, 365};

// Criando DateTime com valor atual
DateTime dateValue = DateTime.Now;
Console.WriteLine(dateValue);

// Teste com AddHours
foreach (double hour in hours)
    Console.WriteLine("{0} + {1} hour(s) = {2}", dateValue, hour, dateValue.AddHours(hour));

// Teste com Propriedades
Console.WriteLine($"{dateValue.DayOfWeek} {dateValue.Day}/{dateValue.Month}/{dateValue.Year} - {dateValue.Hour}:{dateValue.Minute}:{dateValue.Second}");

// Teste com days in month
foreach (int i in Enumerable.Range(1,12))
{
    DateTime strDate = new DateTime(1,i,1);
    Console.WriteLine($"{strDate.ToString("MMM")} - {DateTime.DaysInMonth(2022,i)} days");
} 
