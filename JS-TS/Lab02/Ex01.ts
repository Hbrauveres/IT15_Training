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
