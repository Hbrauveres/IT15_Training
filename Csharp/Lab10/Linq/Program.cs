List<Pessoa> pessoas = new List<Pessoa>
{
    new Pessoa{Nome="Ana", DataNascimento=new DateTime(1980,3,14), Casada=true},
    new Pessoa{Nome="Paulo", DataNascimento=new DateTime(1978,10,23), Casada=true},
    new Pessoa{Nome="Maria", DataNascimento=new DateTime(2000,1,10), Casada=false},
    new Pessoa{Nome="Carlos", DataNascimento=new DateTime(1999,12,12), Casada=false}
};

var linq1 = from p in pessoas
            where p.Casada && p.DataNascimento >= new DateTime(1980,1,1)
            select p;

foreach  (var pessoa in linq1)
{
    Console.WriteLine(pessoa);
}

Console.WriteLine("------------------------------------");
var linq2 = pessoas.Where(p => p.Casada && p.DataNascimento >= new DateTime(1980,1,1));

foreach (var pessoa in linq2)
{
    Console.WriteLine(pessoa);
}

// Consulta pessoas agrupadas + numero de casados e solteiros
Console.WriteLine("------------------------------------");
var linq3 = from p in pessoas
            group p by p.Casada into estadoCivil
            select new
            {
                Casado = estadoCivil.Key,
                Count = estadoCivil.Count(),
            };

foreach (var pessoa in linq3)
{
    Console.WriteLine(pessoa);
}

// Consulta pessoa mais velha
Console.WriteLine("------------------------------------");
var linq4 = pessoas.MinBy(p => p.DataNascimento);
Console.WriteLine(linq4);

// Consulta pessoa solteira mais nova
Console.WriteLine("------------------------------------");
var linq5 = pessoas.Where(p => !p.Casada).MaxBy(p => p.DataNascimento);
Console.WriteLine(linq5);