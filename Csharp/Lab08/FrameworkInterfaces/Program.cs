string[] lista = {"Julio", "Lucia", "Daniel", "Joao"};

Console.WriteLine("Array de strings antes da ordenacao");
for (int i = 0; i < lista.Length; i++)
    Console.Write(lista[i]+ " ");
Console.WriteLine("\n");

Array.Sort(lista); // Oredena lista de strings

Console.WriteLine("Array de strings depois da ordenacao");
for (int i = 0; i < lista.Length; i++)
    Console.Write(lista[i] + " ");
Console.WriteLine("\n");

Pessoa[] lista2 = { new Pessoa("Jose", 25), new Pessoa("Ana", 28), new Pessoa("Paulo", 20)};

Array.Sort(lista2); // Ordena lista de objetos Pessoa

Console.WriteLine("Array de objetos depois da ordenacao padrao(Nome)");
for (int i = 0; i < lista2.Length; i++)
    Console.Write(lista2[i].Nome + " ");
Console.WriteLine("\n");

// Ordenação por Idade
Pessoa.ComparaPor = 1; // Define valor da variavel de classe que decide metodo de ordenação
Array.Sort(lista2);  // Ordena pelo metodo selecionado na variavel de classe "comparaPor"
Console.WriteLine("Array de objetos depois da ordenacao por Idade");
for (int i = 0; i < lista2.Length; i++)
    Console.Write(lista2[i].Nome + " ");
Console.WriteLine("\n");


// Ordenação por Nome
Pessoa.ComparaPor = 0;
Array.Sort(lista2);
Console.WriteLine("Array depois da ordenacao por Nome");
for (int i = 0; i < lista2.Length; i++)
    Console.Write(lista2[i].Nome + " ");
Console.WriteLine("\n");

// Ordenação utilizando o IComparer

Array.Sort(lista2,Pessoa.OrdenaPorIdade());
Console.WriteLine("Array depois da ordenacao por Idade utilizando IComparer");
for (int i = 0; i < lista2.Length; i++)
    Console.Write(lista2[i].Nome + " ");
Console.WriteLine("\n");

Array.Sort(lista2,Pessoa.OrdenaPorNome());
Console.WriteLine("Array depois da ordenacao por Nome utilizando IComparer");
for (int i = 0; i < lista2.Length; i++)
    Console.Write(lista2[i].Nome + " ");
Console.WriteLine("\n");