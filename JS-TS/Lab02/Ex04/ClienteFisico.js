import { Cliente } from './Cliente.js';
export class ClienteFisico extends Cliente {
    constructor(nome, _idade, _salario) {
        super(nome);
        this._idade = _idade;
        this._salario = _salario;
    }
    get idade() { return this._idade; }
    set idade(idade) { this._idade = idade; }
    get salario() { return this._salario; }
    set salario(salario) { this._salario = salario; }
    getMensalidade() {
        if (this._idade < 60) {
            return this._salario * 0.1;
        }
        else {
            return this._salario * 0.15;
        }
    }
}
