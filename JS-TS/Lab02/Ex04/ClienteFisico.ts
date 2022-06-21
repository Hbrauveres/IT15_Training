import {Cliente} from './Cliente.js'

export class ClienteFisico extends Cliente{
    constructor(nome:string, private _idade:number, private _salario:number){
        super(nome);
    }
    get idade():number{return this._idade}
    
    set idade(idade:number){this._idade = idade}
    
    get salario():number{return this._salario}
    
    set salario(salario:number){this._salario = salario}
    
    getMensalidade():number{
        if(this._idade < 60){
            return this._salario * 0.1
        }
        else{
            return this._salario * 0.15
        }
    }
}