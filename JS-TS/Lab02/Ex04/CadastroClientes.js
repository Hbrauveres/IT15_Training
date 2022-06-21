export class CadastroClientes {
    constructor(_clientes = []) {
        this._clientes = _clientes;
    }
    adicionarCliente(cliente) {
        this._clientes.push(cliente);
    }
    listarClientes() {
        return this._clientes;
    }
    getNomeMensalidade() {
        return this._clientes.map(cliente => `Nome: ${cliente.nome} - Mensalidade: ${cliente.getMensalidade()}`);
    }
}
