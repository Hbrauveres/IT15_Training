import { Cliente } from "./Cliente.js"


export class CadastroClientes{
    constructor(private _clientes:Cliente[] = []){}

    adicionarCliente(cliente:Cliente){
        this._clientes.push(cliente)
    }

    listarClientes():Cliente[]{
        return this._clientes;
    }

    getNomeMensalidade(){
        return this._clientes.map(cliente => `Nome: ${cliente.nome} - Mensalidade: ${cliente.getMensalidade()}`)
    }
}