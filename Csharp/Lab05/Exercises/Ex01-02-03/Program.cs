using System.Drawing;

Circulo c1 = new Circulo();
Console.WriteLine(c1);
Console.WriteLine($"CentroX={c1.CentroX}");
Console.WriteLine($"CentroY={c1.CentroY}");

Circulo c2 = new Circulo(2.4,5,3);
Console.WriteLine(c2);
Console.WriteLine($"CentroX={c2.CentroX}");
Console.WriteLine($"CentroY={c2.CentroY}");

CirculoColorido c3 = new CirculoColorido();
Console.WriteLine(c3);
Console.WriteLine($"CentroX={c3.CentroX}");
Console.WriteLine($"CentroY={c3.CentroY}");
Console.WriteLine($"Cor={c3.Cor}");

CirculoColorido c4 = new CirculoColorido(1.5,3.1,1,"Purple");
Console.WriteLine(c4);
Console.WriteLine($"CentroX={c4.CentroX}");
Console.WriteLine($"CentroY={c4.CentroY}");
Console.WriteLine($"Cor={c4.Cor}");

CirculoColoridoPreenchido c5 = new CirculoColoridoPreenchido(2.0,5.0,2.75,"White", Color.Azure);
Console.WriteLine(c5);
Console.WriteLine($"CentroX={c5.CentroX}");
Console.WriteLine($"CentroY={c5.CentroY}");
Console.WriteLine($"Cor={c5.Cor}");
Console.WriteLine($"CorPreenchimento={c5.CorPreenchimento.Name}");

Circulo[] arrayCirculos = new Circulo[] {c1,c2,c3,c4,c5};

foreach (Circulo circulo in arrayCirculos)
{
    Console.WriteLine(circulo);
}

