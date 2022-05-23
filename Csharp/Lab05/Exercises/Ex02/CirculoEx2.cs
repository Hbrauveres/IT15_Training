using System;
using System.Drawing;

public class CirculoEx2
{
    private double coordX;
    private double coordY;
    private double raio;

    public CirculoEx2() : this(0,0,1)
    {
    }

    public CirculoEx2(double x, double y, double r)
    {
        coordX = x;
        coordY = y;
        raio = Math.Abs(r);
    }

    public double CentroX
    {
        get { return coordX; }
        set { coordX = value; }
    }
    public double CentroY
    {
        get { return coordY;}
        set { coordY = value; }
    }

    public double Raio
    {
        get { return raio; }
        set { raio = value; }
    }
    
    public override string ToString()
    {
        return "(" + string.Format("{0:F2}", CentroX) + ";" + string.Format("{0:F2}", CentroY + ")" + " raio=" + string.Format("{0:F2}", Raio));
    }
}

public class CirculoColoridoEx2 : CirculoEx2
{
    private string minhaCor;
    public string Cor
    {
        get { return minhaCor;}
        set { minhaCor = value;}
    }
    public CirculoColoridoEx2()
    {
        minhaCor = "Preto";
    }
    public CirculoColoridoEx2(double x, double y, double r, string c) : base(x,y,r)
    {
        minhaCor = c;
    }

    public override string ToString()
    {
        return base.ToString() + " cor=" + minhaCor; 
    }
}

public class CirculoColoridoPreenchidoEx2 : CirculoColoridoEx2
{
    public Color CorPreenchimento { get; set; }

    public CirculoColoridoPreenchidoEx2(double x, double y, double r, string c, Color cP) : base(x,y,r,c)
    {
        CorPreenchimento = cP;
    }

    public override string ToString()
    {
        return base.ToString() + $"Cor Preenchimento={CorPreenchimento.Name}";
    }
}