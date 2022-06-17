// 1. Crie uma classe que represente um Círculo. Esta classe deve 
// possuir as propriedades de um ponto central (coordenadas x, y) e 
// um tamanho de raio. Defina métodos para o cálculo da área do círculo 
// e do comprimento da circunferência. Escreva um bloco de código para 
// testar a implementação do círculo.

class Circulo {
    x: number;
    y: number;
    raio: number;
  
    constructor(x: number, y: number, raio: number) {
      this.x = x;
      this.y = y;
      this.raio = raio;
    }
   
    circunferencia() {
      return (2 * Math.PI * this.raio);
    }
  
    areaCirculo()
    {
      return (Math.PI * (this.raio ** 2));
    }
  }
  
  let c1 = new Circulo(1,1,20)
  
  console.log(c1.areaCirculo());
  console.log(c1.circunferencia());