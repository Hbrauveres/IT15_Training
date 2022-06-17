export class Cofrinho {
    constructor(_moedas) {
        this._moedas = _moedas;
    }
    adicionar(moeda) {
        this._moedas.push(moeda);
    }
    calcularTotal(nome_moeda) {
        let total = 0;
        for (let i = 0; i < this._moedas.length; i++) {
            if (this._moedas[i].nome == nome_moeda) {
                total += this._moedas[i].valor;
            }
        }
        return total;
    }
}
