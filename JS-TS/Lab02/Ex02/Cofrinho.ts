import { Moeda } from "./Moeda.js";

export class Cofrinho{
    constructor(private _moedas:Moeda[]){
    }      
    

    adicionar(moeda:Moeda){
        this._moedas.push(moeda);
    }

    calcularTotal(nome_moeda : string):number{
        let total:number = 0;
        for(let i = 0; i < this._moedas.length; i++){
            if(this._moedas[i].nome == nome_moeda){
                total += this._moedas[i].valor;
            }
        }
        return total;
    }
}