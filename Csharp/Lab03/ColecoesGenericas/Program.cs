// Alocar, Inicializar e Acessar dados em uma lista
List<string> listaStrings = new List<string>();
listaStrings.Add("Um");
listaStrings.Add("Dois");
listaStrings.Add("Tres");

foreach (string str in listaStrings)
{
    Console.WriteLine(str);
}

//[erro] listaStrings.Add(10); // Causa erro pois 10 é int não string.

// Alocar, Inicializar e acessar dados em fila
Queue<object> q = new Queue<object>();
q.Enqueue(".Net Framework");
q.Enqueue(new Decimal(123.456));
q.Enqueue(654.321);

//Ler os elementos da fila
/* 
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(q.ElementAt(i));
}
*/

// Esvaziar fila
while(q.Count != 0)
{
    Console.WriteLine(q.Dequeue());
}

// Criar fila de inteiros
Queue<int> minhaFila = new Queue<int>();
minhaFila.Enqueue(10);
minhaFila.Enqueue(200);
minhaFila.Enqueue(1000);
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());

// Manipulando dicionarios genericos
Dictionary<int,string> paises = new Dictionary<int, string>();
paises[44] = "Reino Unido";
paises[33] = "França";
paises[55] = "Brasil";
Console.WriteLine("O código 55 é: {0}", paises[55]);
foreach (KeyValuePair<int,string> item in paises)
{
    int codigo = item.Key;
    string pais = item.Value;
    Console.WriteLine("Código {0} = {1}", codigo, pais);
}