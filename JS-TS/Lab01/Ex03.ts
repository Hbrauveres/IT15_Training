// 3. Escreva uma função min(x,y) que devolve o menor entre dois números. 
// Não use funções auxiliares de Math. Utilize corretamente a declaração de 
// tipos nos parâmetros e no resultado da função.

function min(x:number, y:number) : number{
    let menor:number = x;
    if(x > y){
        menor = y;
    }
    return menor;
}

console.log(min(3, -5));