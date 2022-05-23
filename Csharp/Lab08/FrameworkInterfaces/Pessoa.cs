public class Pessoa : IComparable<Pessoa>
{
    private string meuNome;
    private int minhaIdade;
    private static int comparaPor = 0;

    public Pessoa(string n, int i)
    {
        meuNome = n;
        minhaIdade = i;
    }

    public string Nome
    {
        get { return meuNome; }
    }

    public int Idade
    {
        get { return minhaIdade; }
        set { minhaIdade = value; }
    }

    public static int ComparaPor
    {
        set { comparaPor = value; }
    }

    public int CompareTo(Pessoa outro)
    {
        if (comparaPor == 1)
        {
            return minhaIdade.CompareTo(outro.minhaIdade);
        }
        else
        {  
            return meuNome.CompareTo(outro.meuNome);
        }
    }

    public static IComparer<Pessoa> OrdenaPorIdade()
    {
        return new ComparaIdade();
    }

    public static IComparer<Pessoa> OrdenaPorNome()
    {
        return new ComparaNome();
    }


    // Implementação do comparador utilizando IComparer
    private class ComparaIdade : IComparer<Pessoa>
    {
        public int Compare(Pessoa p1, Pessoa p2)
        {
            if(p1.minhaIdade > p2.minhaIdade) return 1;
            if(p1.minhaIdade < p2.minhaIdade) return -1;
            else return 0;
        }
    }

    private class ComparaNome : IComparer<Pessoa>
    {
        public int Compare(Pessoa p1, Pessoa p2)
        {
            return String.Compare(p1.meuNome, p2.meuNome);
        }
    }
}