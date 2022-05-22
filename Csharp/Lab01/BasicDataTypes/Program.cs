// Tipos-Valor Fundamentais Byte, int, long
// Byte
byte b;
b = byte.MaxValue;
Console.WriteLine($"Valor maximo de byte: {b}");

// Int
int i;
i = int.MaxValue;
Console.WriteLine($"Valor maximo do int: {i}");

// Long
long l;
l = long.MaxValue;
Console.WriteLine($"Valor maximo do long: {l}");

// Trabalhando com Strings
// String

string strUm = "Alo ";
string strDois = "Mundo";
string strTres = strUm + strDois;

Console.WriteLine(strTres);

int tresTamanho = strTres.Length;
string strQuatro = "Tam = " + tresTamanho.ToString();
Console.WriteLine(strQuatro);

Console.WriteLine(strTres.Substring(0,5));

// Trabalhando com objetos do Framework
// DateTime

DateTime dt = new DateTime(2015, 04, 23);

string strCinco = dt.ToString();

Console.WriteLine(strCinco);