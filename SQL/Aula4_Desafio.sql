-- Unidade 3 - Manipulacao Avançada de Dados - Parte 2
-- 6.PRATICA
-- a) Qual a quantidade de endereços por estado? 
SELECT ESTADOS.uf,COUNT(ENDERECOS.cod_endereco) AS NumEnderecos FROM ESTADOS
JOIN CIDADES ON CIDADES.uf = ESTADOS.uf
JOIN ENDERECOS ON CIDADES.cod_cidade = ENDERECOS.cod_cidade
GROUP BY ESTADOS.uf

-- b) Qual a quantidade de clientes de cada estado? 
SELECT CIDADES.uf, COUNT(DISTINCT CLIENTES_ENDERECOS.cod_cliente) as NumClientes 
FROM CLIENTES_ENDERECOS
JOIN ENDERECOS ON ENDERECOS.cod_endereco = CLIENTES_ENDERECOS.cod_endereco
JOIN CIDADES ON ENDERECOS.cod_cidade = CIDADES.cod_cidade
GROUP BY CIDADES.uf;

-- c) Qual  o  ranking  de  estados  por  quantidade  de  clientes,  ou  seja,  em  ordem decrescente de quantidade de clientes? 
SELECT CIDADES.uf, COUNT(DISTINCT CLIENTES_ENDERECOS.cod_cliente) as NumClientes 
FROM CLIENTES_ENDERECOS
JOIN ENDERECOS ON ENDERECOS.cod_endereco = CLIENTES_ENDERECOS.cod_endereco
JOIN CIDADES ON ENDERECOS.cod_cidade = CIDADES.cod_cidade
GROUP BY CIDADES.uf
ORDER BY NumClientes DESC;

-- d) Qual  o  ranking  de  regiões  por  quantidade  de  clientes,  ou  seja,  em  ordem decrescente de quantidade de clientes? 
SELECT ESTADOS.regiao, COUNT(DISTINCT CLIENTES_ENDERECOS.cod_cliente) as NumClientes 
FROM CLIENTES_ENDERECOS
JOIN ENDERECOS ON ENDERECOS.cod_endereco = CLIENTES_ENDERECOS.cod_endereco
JOIN CIDADES ON ENDERECOS.cod_cidade = CIDADES.cod_cidade
JOIN ESTADOS ON ESTADOS.uf = CIDADES.uf
GROUP BY ESTADOS.regiao
ORDER BY NumClientes DESC;

-- e) Qual a quantidade de pedidos por região? 
SELECT ESTADOS.regiao, COUNT(PEDIDOS.num_pedido) as NumPedidos
FROM PEDIDOS
JOIN CLIENTES_ENDERECOS ON (PEDIDOS.cod_cliente = CLIENTES_ENDERECOS.cod_cliente AND PEDIDOS.cod_endereco = CLIENTES_ENDERECOS.cod_endereco)
JOIN ENDERECOS ON ENDERECOS.cod_endereco = CLIENTES_ENDERECOS.cod_endereco
JOIN CIDADES ON ENDERECOS.cod_cidade = CIDADES.cod_cidade
JOIN ESTADOS ON ESTADOS.uf = CIDADES.uf
GROUP BY ESTADOS.regiao;

-- f) Qual  a  quantidade  de  pedidos  por  ano  e  por  região,  considerando  apenas  os pedidos feitos nos anos de 2000 até 2004? 
SELECT ESTADOS.regiao, YEAR(PEDIDOS.data_emissao) AS Anos, COUNT(PEDIDOS.num_pedido) as NumPedidos
FROM PEDIDOS
JOIN CLIENTES_ENDERECOS ON (PEDIDOS.cod_cliente = CLIENTES_ENDERECOS.cod_cliente AND PEDIDOS.cod_endereco = CLIENTES_ENDERECOS.cod_endereco)
JOIN ENDERECOS ON ENDERECOS.cod_endereco = CLIENTES_ENDERECOS.cod_endereco
JOIN CIDADES ON ENDERECOS.cod_cidade = CIDADES.cod_cidade
JOIN ESTADOS ON ESTADOS.uf = CIDADES.uf
GROUP BY ESTADOS.regiao, YEAR(PEDIDOS.data_emissao)
HAVING YEAR(PEDIDOS.data_emissao) BETWEEN 2000 AND 2004;

-- g) Qual  o  valor  total  gasto por  cliente,  ordenado  em  ordem decrescente  de  valor total? 
SELECT PEDIDOS.cod_cliente, SUM(PEDIDOS_PRODUTOS.quantidade * PEDIDOS_PRODUTOS.valor_unitario) AS ValorTotal
FROM PEDIDOS_PRODUTOS
JOIN PEDIDOS ON PEDIDOS_PRODUTOS.num_pedido = PEDIDOS.num_pedido
GROUP BY PEDIDOS.cod_cliente
ORDER BY ValorTotal;

SELECT TOP(1) * FROM pedidos_produtos
JOIN PEDIDOS ON PEDIDOS_PRODUTOS.num_pedido = PEDIDOS.num_pedido
WHERE cod_cliente = 18
ORDER BY valor_unitario DESC;

-- h) Qual  o  valor  total  gasto por  cliente,  ordenado  em  ordem decrescente  de  valor total, considerando apenas os clientes do Rio Grande do Sul? 
SELECT c.cod_cliente, SUM(pp.quantidade * pp.valor_unitario) as Gasto_total
FROM clientes as c
JOIN pedidos as p ON c.cod_cliente = p.cod_cliente
JOIN pedidos_produtos as pp ON p.num_pedido = pp.num_pedido
JOIN clientes_enderecos as cliend ON cliend.cod_cliente = p.cod_cliente AND p.cod_endereco = cliend.cod_endereco
JOIN enderecos as en ON en.cod_endereco = cliend.cod_endereco
JOIN cidades as cid ON cid.cod_cidade = en.cod_cidade
WHERE cid.uf = 'RS'
GROUP BY c.cod_cliente, cid.uf
ORDER BY Gasto_total DESC;

-- i) Qual o valor total vendido por autor? 
SELECT A.nome, A.cod_autor, SUM(pp.quantidade * pp.valor_unitario) as total
FROM autores as A
JOIN autores_produtos as AP ON A.cod_autor = AP.cod_autor 
JOIN pedidos_produtos as PP ON AP.cod_produto = PP.cod_produto
GROUP BY A.nome, A.cod_autor
ORDER BY A.cod_autor;

-- j) Qual o valor médio faturado com as vendas por produto?
SELECT p.cod_produto, avg(quantidade * valor_unitario)
from produtos as p join pedidos_produtos as pp on p.cod_produto = pp.cod_produto
group by p.cod_produto;

-- k) Qual o valor total de cada pedido? 
SELECT P.num_pedido, SUM(quantidade * valor_unitario)
FROM pedidos as P join pedidos_produtos as PP ON p.num_pedido = pp.num_pedido
GROUP BY num_pedido;

-- l) Qual o valor médio dos pedidos por estado?
-- Não funciona no SQL SERVER, precisa traduzir para codigo mssqlserver
select uf, sum(quantidade * valor_unitario) / count(distinct num_pedido)
from estados join cidades using(uf)
             join enderecos using(cod_cidade)
             join clientes_enderecos using(cod_endereco)
             join pedidos using(cod_cliente,cod_endereco)
             join pedidos_produtos using(num_pedido)
group by uf;

