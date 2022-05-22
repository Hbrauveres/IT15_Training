using System;

class ContaCorrenteEx
{
    private decimal saldo;
    private string nome;
    private int numOperacoes = 0;
    private decimal media;
    private decimal acumulador;
    private DateTime dataCriacao = DateTime.Now;

    public ContaCorrenteEx(string n, decimal s = 0)
    {
        saldo = s;
        nome = n;
    }

    public string Nome
    {
        get { return nome; }
    }

    public decimal Media
    {
        get { return media; }
    }

    public decimal Acumulador
    {
        get { return acumulador; }
    }

    public decimal Saldo
    {
        get { return saldo; }  
    } 

    public void Depositar(decimal val)
    {
        saldo = saldo + val;
        CalculaMedia(val);
    }

    public void Sacar(decimal val)
    {
        saldo = saldo - val;
        CalculaMedia(val);
    }

    private void CalculaMedia(decimal val)
    {
        numOperacoes++;
        acumulador += val;
        media = acumulador/numOperacoes;
    }
}