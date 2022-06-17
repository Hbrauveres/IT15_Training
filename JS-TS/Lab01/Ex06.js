// 6. Escreva uma função getMax(arr) que recebe um array de número 
// inteiros e retorna o maior elemento encontrado no array. Assuma que 
// o array não está vazio. Não utilize funções auxiliares de outros objetos 
// disponibilizados pelo TypeScript. Utilize corretamente a declaração de 
// tipos nos parâmetros e no resultado da função.
var Circulo = /** @class */ (function () {
    function Circulo(x, y, raio) {
        this.x = x;
        this.y = y;
        this.raio = raio;
    }
    Circulo.prototype.circunferencia = function () {
        return (2 * Math.PI * this.raio);
    };
    Circulo.prototype.areaCirculo = function () {
        return (Math.PI * (Math.pow(this.raio, 2)));
    };
    return Circulo;
}());
var c1 = new Circulo(1, 1, 20);
console.log(c1.areaCirculo());
console.log(c1.circunferencia());
