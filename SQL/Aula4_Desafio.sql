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

-- i) Qual o valor total vendido por autor? 

-- j) Qual o valor médio faturado com as vendas por produto? 

-- k) Qual o valor total de cada pedido? 

-- l) Qual o valor médio dos pedidos por estado?
