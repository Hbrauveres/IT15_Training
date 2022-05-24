public class TermometroLimite : Termometro
{
    private double limiteSuperior;
    private bool disparadoEventoLimite;

    public TermometroLimite(double ls)
    {
        limiteSuperior = ls;
        disparadoEventoLimite = false;
    }

    public double LimiteSuperior
    {
        get { return limiteSuperior; }
        set { limiteSuperior = value; }
    }

    public delegate void MeuDelegate(string msg);
    public event MeuDelegate EventoLimiteSuperior;
    public event MeuDelegate EventoNormalizacao;
    private void TestaEventoDeLimiteSuperior()
    {
        // Verifica se temperatura ja passou do limite
        // Verifica se o evento ja foi disparado e evitar multiplos disparos
        if((this.Temperatura > limiteSuperior) && (!disparadoEventoLimite))
           // Verifica se há tratador
           if(EventoLimiteSuperior != null)
           {
               EventoLimiteSuperior($"ATENÇÃO: TEMPERATURA ACIMA DO LIMITE!!\n         TEMPERATURA: {this.Temperatura}");
               disparadoEventoLimite = true;
           }
    }

    private void TestaEventoNormalizacao()
    {
        // Verifica se temperatura voltou diminuiu abaixo limite
        // Verifica se o evento ja foi disparado e evitar multiplos disparos
        if((this.Temperatura <= limiteSuperior) && (disparadoEventoLimite))
           // Verifica se há tratador
           if(EventoNormalizacao != null)
           {
               EventoNormalizacao($"ATENÇÃO: TEMPERATURA NORMALIZADA.\n         TEMPERATURA: {this.Temperatura}");
               disparadoEventoLimite = false;
           }
    }

    public override void Aumentar()
    {
        base.Aumentar();
        TestaEventoDeLimiteSuperior();
    }

    public override void Aumentar(double quantia)
    {
        base.Aumentar(quantia);
        TestaEventoDeLimiteSuperior();
    }

    public override void Dimunuir()
    {
        base.Dimunuir();
        TestaEventoNormalizacao();
    }

    public override void Dimunuir(double quantia)
    {
        base.Dimunuir(quantia);
        TestaEventoNormalizacao();
    }
}