// Criacao de Classes, Descricao de Atributos e Metodos
/*
ContaCorrente minhaConta = new ContaCorrente();

minhaConta.Depositar(100);
minhaConta.Sacar(50);
*/

ContaCorrente minhaConta = new ContaCorrente(340);
Console.WriteLine(minhaConta.Saldo);
minhaConta.Depositar(100);
Console.WriteLine(minhaConta.Saldo);
minhaConta.Sacar(50);
Console.WriteLine(minhaConta.Saldo);