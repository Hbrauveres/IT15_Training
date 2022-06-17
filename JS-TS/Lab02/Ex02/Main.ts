// 2. Sejam os seguintes objetos representados em um diagrama de classes UML:
//a) Implemente as classes correspondentes. Você pode implementar os métodos get 
//   apresentados na classe Moeda como: campos somente de leitura, métodos de acesso 
//   ou propriedades de leitura. Utilize uma coleção adequada para implementar a coleção 
//   de moedas na classe Cofrinho.
//b) Escreva um bloco de código para testar a implementação.
//c) Utilize um código para serializar um objeto Cofrinho em JSON e procure entender 
//   o formato de string que foi construído.

import { Moeda } from './Moeda.js';
import { Cofrinho } from './Cofrinho.js';


const nome_moeda : string[] = ["Real","Dolar","Euro"];
const val_moedas : number[] = [0.05,0.10,0.25,0.5,1,2,5,10,20,50,100];

let cofrinho : Cofrinho = new Cofrinho([]);

for(let i = 0; i < 100; i++){
    const random_nome = Math.floor(Math.random() * nome_moeda.length);
    const random_valor = Math.floor(Math.random() * val_moedas.length);
    let moeda : Moeda = new Moeda(val_moedas[random_valor],nome_moeda[random_nome]);
    cofrinho.adicionar(moeda);
}

console.log("Total em Real: " + cofrinho.calcularTotal("Real"));
console.log("Total em Dolares: " + cofrinho.calcularTotal("Dolar"));
console.log("Total em Euros: " + cofrinho.calcularTotal("Euro"));
