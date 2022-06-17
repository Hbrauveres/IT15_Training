// 5. Escreva uma função toMaiusculaPrimeira(s) que recebe uma string s 
// (assuma qualquer string não vazia) e retorna a mesma string com a primeira 
// letra em maiúscula. Utilize corretamente a declaração de tipos nos parâmetros 
// e no resultado da função.

function toMaiusculaPrimeira(str : string) : string{
    let primeira : string = str.charAt(0).toUpperCase();
    return primeira.concat(str.substring(1));
}

let str : string = "teste";
str = toMaiusculaPrimeira(str);

console.log(str);