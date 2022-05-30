-- Unidade 2 - Manipulacao Basica de Dados - Parte 4
-- 6.PRATICA
-- 1 O título e o nome do autor dos produtos importados, ordenados pelo título.

SELECT PRODUTOS.TITULO, AUTORES.NOME, PRODUTOS.IMPORTADO FROM AUTORES
	JOIN AUTORES_PRODUTOS AP ON AP.COD_AUTOR = AUTORES.COD_AUTOR
	JOIN PRODUTOS ON PRODUTOS.COD_PRODUTO = AP.COD_PRODUTO
	WHERE PRODUTOS.IMPORTADO = 'S'
	ORDER BY PRODUTOS.TITULO ASC;

-- 2 A quantidade de cidades cadastradas no estado de São Paulo
SELECT COUNT(*) FROM Estados
	JOIN Cidades ON Cidades.uf = Estados.uf
	WHERE Estados.Uf = 'SP';

-- 3 Os nomes, e-mails e números de telefone dos clientes cujos telefones são do código de área (ddd) 51.
SELECT U.NOME, U.EMAIL, T.NUMERO FROM USUARIOS U
	JOIN CLIENTES C ON U.Cod_Usuario = C.Cod_Cliente
	JOIN TELEFONES T ON C.Cod_Cliente = T.Cod_Cliente
	WHERE T.DDD = 51

-- 4 O código, o nome e a região de cada cidade dos estados do Rio Grande do Sul, São Paulo e Pernambuco cujo nome inicia por “Santa”. Ordenar pelo nome da cidade de forma decrescente.
SELECT C.Cod_Cidade, C.Nome, C.Uf FROM CIDADES C
	JOIN Estados E ON C.uf = E.uf
	WHERE E.uf IN ('RS', 'SP', 'PE')
	AND C.Nome LIKE 'Santa %'
	ORDER BY C.Nome DESC;

-- 5 Os nomes dos autores (ordenados e sem repetir) cujos produtos já foram vendidos para algum cliente da região norte.
SELECT DISTINCT A.Nome, ES.regiao FROM Autores A

	-- AUTORES->AUTORESPRODUTOS
	JOIN autores_produtos AP on A.cod_autor = AP.cod_autor

	-- AUTORESPRODUTOS->PRODUTOS 
	JOIN produtos P on P.cod_produto = AP.cod_produto

	-- PRODUTOS->PEDIDOSPRODUTOS
	JOIN pedidos_produtos PP on PP.cod_produto = P.cod_produto

	-- PEDIDOSPRODUTOS->PEDIDOS
	JOIN pedidos PE on PE.num_pedido = PP.num_pedido

	-- PEDIDOS->CLIENTESENDERECOS
	--JOIN clientes_enderecos CE on CE.cod_cliente = pe.cod_cliente
	--JOIN clientes_enderecos CE on CE.cod_endereco = pe.cod_endereco
	--????????????????????????????????????????????????? POR QUE É DIFERENTE????????????????????????????????????????????????????????????????????????????????

	-- CLIENTESENDERECOS->ENDERECOS
	JOIN enderecos E on E.cod_endereco = CE.cod_endereco

	-- ENDERECOS->CIDADES
	JOIN cidades C on C.cod_cidade = E.cod_cidade

	-- CIDADES->ESTADOS
	JOIN estados ES on C.uf = ES.uf

	WHERE ES.regiao = 'N'