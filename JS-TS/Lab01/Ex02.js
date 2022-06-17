// 2. Qual o resultado do seguinte bloco de comandos? 
// Qual a explicação para o resultado?
// declara variavel i com o tipo number
var i = 0;
console.log(i);
// loop while
// enquanto i for diferente de 10
while (i != 10) {
    // i soma 0.2
    i += 0.2;
    // devido a um problema de precisão do javascript o resultado nunca é == 10
}
// imprime na tela o valor de i
console.log(i);
