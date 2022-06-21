import { Cliente } from './Cliente.js';
export class ClienteJuridico extends Cliente {
    constructor(nome, _mensalidade) {
        super(nome);
        this._mensalidade = _mensalidade;
    }
    get mensalidade() { return this._mensalidade; }
    set mensalidade(mensalidade) { this._mensalidade = mensalidade; }
    getMensalidade() { return this._mensalidade; }
}
