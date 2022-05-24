static void  TrataLimiteSuperior(string msg)
{
    Console.WriteLine(msg);
}

static void TrataNormalizacao(string msg)
{
    Console.WriteLine(msg);
}

// Inicializa o termometro e mostra seu valor
TermometroLimite term = new TermometroLimite(5);
Console.WriteLine(term.ToString());

// Adiciona um tratador ao evento EventoLimiteSuperior
term.EventoLimiteSuperior += new TermometroLimite.MeuDelegate(TrataLimiteSuperior);
term.EventoNormalizacao += new TermometroLimite.MeuDelegate(TrataNormalizacao);

// Aumenta a temperatura além do limite
term.Aumentar(6);
Console.WriteLine(term.ToString());
term.Dimunuir(0.5);
Console.WriteLine(term.ToString());
term.Dimunuir(0.5);
Console.WriteLine(term.ToString());
term.Dimunuir(0.5);
Console.WriteLine(term.ToString());
term.Dimunuir(0.5);
Console.WriteLine(term.ToString());
term.Dimunuir(0.5);
Console.WriteLine(term.ToString());
term.Aumentar(10);
Console.WriteLine(term.ToString());

