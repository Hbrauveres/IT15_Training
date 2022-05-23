using System.Drawing;

CirculoEx2 circ1 = new CirculoEx2();
Console.WriteLine(circ1);
CirculoEx2 circ2 = new CirculoEx2(2.4,5,3);
Console.WriteLine(circ2);
CirculoColoridoEx2 circ3 = new CirculoColoridoEx2();
Console.WriteLine(circ3);
CirculoColoridoEx2 circ4 = new CirculoColoridoEx2(1.5,3.1,1,"Vermelho");
Console.WriteLine(circ4);

Console.WriteLine($"circ4.CentroX = {circ4.CentroX}\ncirc4.CentroY = {circ4.CentroY}");
// Sim, é possivel acessar as propriedades da classe base através da classe herdada.

CirculoColoridoPreenchidoEx2 circ5 = new CirculoColoridoPreenchidoEx2(1.5,3.1,1,"Vermelho",Color.White);
Console.WriteLine(circ5);