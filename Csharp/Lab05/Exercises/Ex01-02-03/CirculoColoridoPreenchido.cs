using System.Drawing;
public class CirculoColoridoPreenchido : CirculoColorido
{
    public Color CorPreenchimento { get; set; }

    public CirculoColoridoPreenchido(double x, double y, double r, string c, Color cP) : base(x,y,r,c)
    {
        CorPreenchimento = cP;
    }

    public override string ToString()
    {
        return base.ToString() + $"Cor Preenchimento={CorPreenchimento.Name}";
    }
}