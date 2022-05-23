CirculoEx1 circ1 = new CirculoEx1();
Console.WriteLine(circ1);
CirculoEx1 circ2 = new CirculoEx1(2.4,5,3);
Console.WriteLine(circ2);
CirculoColoridoEx1 circ3 = new CirculoColoridoEx1();
Console.WriteLine(circ3);
CirculoColoridoEx1 circ4 = new CirculoColoridoEx1(1.5,3.1,1,"Vermelho");
Console.WriteLine(circ4);

Console.WriteLine($"circ4.CentroX = {circ4.CentroX}\ncirc4.CentroY = {circ4.CentroY}");
// Sim, é possivel acessar as propriedades da classe base através da classe herdada.