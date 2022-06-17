// 4. Escreva uma função pow(x,y) que calcula o valor de x^y, ou seja, 
// x elevado a potência y. Assuma que os valores de x e y são números 
// inteiros não negativos e que 𝑥0=1 para qualquer valor de x. Apresente 
// uma versão iterativa e uma versão recursiva para a função. Não utilize o 
// operador **. Utilize corretamente a declaração de tipos nos parâmetros e 
// no resultado da função.
function pow_rec(x, y) {
    if (y == 0)
        return 1;
    return (x * pow_rec(x, y - 1));
}
function pow(x, y) {
    var result = 1;
    while (y > 0) {
        result *= x;
        y--;
    }
    return result;
}
console.log("Potencia recursivo: " + pow_rec(2, 3));
console.log("Potencia iterativo: " + pow(2, 3));
