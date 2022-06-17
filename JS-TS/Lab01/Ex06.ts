// 6. Escreva uma função getMax(arr) que recebe um array de número 
// inteiros e retorna o maior elemento encontrado no array. Assuma que 
// o array não está vazio. Não utilize funções auxiliares de outros objetos 
// disponibilizados pelo TypeScript. Utilize corretamente a declaração de 
// tipos nos parâmetros e no resultado da função.

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