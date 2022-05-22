using System;

class ContaCorrente
{
    private decimal saldo; // Inicializado por padrão por 0
    
    public ContaCorrente(decimal val)
    {
        saldo = val;
    }
    
    public decimal Saldo
    {
        get{ return saldo; }
    }

    public void Depositar(decimal val)
    {
        saldo = saldo + val;
    }

    public void Sacar(decimal val)
    {
        saldo = saldo - val;
    }
}
