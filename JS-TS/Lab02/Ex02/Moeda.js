export class Moeda {
    constructor(_valor, _nome) {
        this._valor = _valor;
        this._nome = _nome;
    }
    get valor() {
        return this._valor;
    }
    get nome() {
        return this._nome;
    }
}
