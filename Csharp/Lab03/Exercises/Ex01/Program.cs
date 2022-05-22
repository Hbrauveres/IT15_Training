Dictionary<int,string> paises = new Dictionary<int, string>();
paises[44] = "Reino Unido";
paises[33] = "França";
paises[55] = "Brasil";

Console.WriteLine("O código 55 é: {0}", paises[55]);

string pais = "Brasil";

var chave = paises.FirstOrDefault(x => x.Value == pais).Key;

Console.WriteLine(chave);