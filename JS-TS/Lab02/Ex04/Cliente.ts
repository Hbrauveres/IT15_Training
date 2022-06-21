export abstract class Cliente{
    constructor(private _nome:string){}
    
    get nome():string {return this._nome}
    
    abstract getMensalidade():number;
}