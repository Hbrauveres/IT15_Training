// 7. Escreva uma função que, utilizando objetos Map, calcule a 
// frequência de cada número presente em um determinado array contendo 
// números inteiros. Utilize corretamente a declaração de tipos nos 
// parâmetros e no resultado da função.

let array = [1, 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1];
let frequencia = new Map<number,number>()

for(let v of array){
    if(frequencia.has(v)){
        let value = frequencia.get(v);
        if(value != undefined)
            frequencia.set(v, value + 1);
    }else{
        frequencia.set(v,1);
    }
}

for(let [key, value] of frequencia){
    console.log(key + " : " + value);
}