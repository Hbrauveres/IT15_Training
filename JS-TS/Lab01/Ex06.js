// 6. Escreva uma função getMax(arr) que recebe um array de número 
// inteiros e retorna o maior elemento encontrado no array. Assuma que 
// o array não está vazio. Não utilize funções auxiliares de outros objetos 
// disponibilizados pelo TypeScript. Utilize corretamente a declaração de 
// tipos nos parâmetros e no resultado da função.
function getMax(x) {
    var maior = -Infinity;
    for (var i = 0; i < x.length; i++) {
        if (x[i] > maior) {
            maior = x[i];
        }
    }
    return maior;
}
let numeros = [1, 2, 3, 5, 4, 9, 8, 7, 5, 11, 2, 56, 2, 4, 5, 8, 61, 2, 5];
console.log(getMax(numeros));
