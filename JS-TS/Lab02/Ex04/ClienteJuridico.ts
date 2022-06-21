import {Cliente} from './Cliente.js'

export class ClienteJuridico extends Cliente{
    constructor(nome:string, private _mensalidade:number){
        super(nome)
    }
    
    get mensalidade():number{return this._mensalidade}
    
    set mensalidade(mensalidade:number){this._mensalidade = mensalidade}
    
    getMensalidade():number{return this._mensalidade}
}