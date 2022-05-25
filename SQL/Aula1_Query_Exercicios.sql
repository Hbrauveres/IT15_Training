CREATE TABLE Veiculos
(
	placa	CHAR(8),
	ano		NUMERIC(4),
	km		NUMERIC(6),
	marca	VARCHAR(50),
	modelo	VARCHAR(50)
);

INSERT INTO VEICULOS (placa, ano, km, marca, modelo)
VALUES ('IJK-1212', 2012, 0, 'Chevrolet', 'Vectra');

INSERT INTO VEICULOS (placa, ano, km, marca, modelo)
VALUES ('IJM-1556', 2001, 72045, 'Volkswagen', 'Gol');

-- INSERTS NOVOS --

INSERT INTO VEICULOS (placa, ano, km, marca, modelo)
VALUES ('FGF-1646', 1999, 124802, 'Fiat', 'Marea'),
('HQJ-3987', 1967, 14097, 'Chevrolet', 'Veraneio'),
('KFF-6339', 1975, 118236, 'Volkswagen', 'Variant'),
('IVU-7931', 1995, 195398, 'Ford', 'Courier'),
('AJF-7571', 2014, 62438, 'Hyundai', 'Veloster');

INSERT INTO VEICULOS (placa, ano, km, marca, modelo)
VALUES ('IMI-5523', 2000, 96890, 'Fiat', 'Uno'),
('HSQ-8549', 2015, 27563, 'Chevrolet', 'Tracker'),
('FDV-6239', 2008, 150230, 'Renault', 'Clio'),
('PQL-4872', 2017, 10500, 'Nissan', 'Frontier'),
('JGH-3941', 2022, 700, 'Volkswagen', 'Amarok');

INSERT INTO VEICULOS (placa, ano, km, marca, modelo)
VALUES ('IIQ-9714', 2010, 359627, 'Mitsubishi', 'Outlander'),
('HVO-0511', 2008, 41297, 'Volvo', 'V50'),
('NEW-4801', 2012, 26048, 'Citroen', 'Picasso'),
('HPF-8434', 2003, 571039, 'Toyota', 'Sequoia'),
('MWG-8812', 2017, 10496, 'Jeep', 'Wrangler');

SELECT * FROM VEICULOS;

-- DROP TABLE Veiculos;

-- DESAFIOS --
-- 1. Não faz sentido pois é esperado que as placas sejam valores unicos na tabela.
--    Para garantir esse dado seria interessante fazer uma verificação na hora de
--    incluir novas linhas na tabela.

-- 2. Neste momento o valor vai ser adicionado sem nenhum porblema pois não há uma
--    verificação que garanta que o valor de km deva ser maior ou igual a 0;

-- 3. Adicionando tabela de pessoas
CREATE TABLE Pessoas
(
	cpf		CHAR(11),
	nome	VARCHAR(80),
	idade   NUMERIC(3),
	sexo	CHAR(1),
);

INSERT INTO Pessoas (cpf, nome, idade, sexo)
VALUES ('25895626599', 'Guilherme Renato Fernandes', 68, 'M'),
('40559653468', 'Murilo Márcio Martins', 62, 'M'),
('69212025501', 'Emilly Isis Lopes', 33, 'F'),
('78390515296', 'Victor Enzo Giovanni Rocha', 47, 'M'),
('59758948679', 'Jennifer Andrea da Cunha', 71, 'F');

INSERT INTO PESSOAS (nome, cpf, idade, sexo)
VALUES ('Lorenzo Osvaldo Porto', 61741453879, 33, 'M'),
('Luana Renata Francisca Nunes', 12070815749, 21, 'F'),
('Osvaldo Tomás Gonçalves', 74289756549, 47, 'M'),
('Paulo Márcio Henrique Pereira', 81551869896, 68, 'M'),
('Isabelle Kamilly Aurora da Costa', 01850005680, 18, 'F');

INSERT INTO PESSOAS (nome, cpf, idade, sexo)
VALUES ('Silvana Alícia Teresinha Assis', 37011015744, 71, 'F'),
('Flávia Bruna Malu Pires', 95386488708, 24, 'F'),
('Anderson Benjamin Ian Rocha', 18879687255, 42, 'M'),
('Raimundo Cláudio Thomas Almada', 44470885924, 60, 'M'),
('Luana Regina Assunção', 57511034403, 71, 'M');

INSERT INTO Pessoas (cpf, nome, idade, sexo)
VALUES ('94105247921', 'Daniel Hugo Kaique Araújo', 36, 'M'),
('20182573664','Igor Henrique Ribeiro', 74, 'M'),
('51986746569','Isaac Bryan Victor Assis', 25, 'M'),
('00794059325','Isabelly Fabiana Débora Viana', 85, 'F'),
('74925681770', 'Lara Luna Galvão', 30, 'F');

SELECT * FROM PESSOAS;

-- 4. Eu criaria uma coluna da tabela de veiculos com 
--    nome "cpf_dono" e para cada linha eu adicionaria o cpf
--    do dono do carro, assim cada carro possui um dono e 
--    cada pessoa pode possuir mais de um carro.

-- PRATICA --
-- 2.1 Tabela alunos de universidade
CREATE TABLE ALUNOS
(
	matricula CHAR(8),
	nome VARCHAR(80),
	idade NUMERIC(3),
	sexo CHAR(1)
);

INSERT INTO ALUNOS(matricula, nome, idade, sexo)
VALUES ('10825375', 'Ester Joana Porto', 59, 'F'),
('48948858', 'Rafael Renato Souza', 32, 'M'),
('28693383', 'Mário Carlos Eduardo João Fogaça', 60, 'M'),
('29739898', 'Adriana Marli Nascimento', 36, 'F'),
('10122517', 'Theo Anderson Henrique Novaes', 25, 'M');

INSERT INTO ALUNOS (matricula, nome, idade, sexo)
VALUES ('19105600', 'João Pedro Gonçalves', 22, 'M'),
('20114432', 'Juliana Martins Ferreira', 23, 'F'),
('18052233', 'Fabrício De Oliveira Júnior', 21, 'M'),
('19116522', 'Enzo Romano Machado', 19, 'M'),
('20127731', 'Valentina Silva de Sá', 25, 'F');

SELECT * FROM ALUNOS;

--2.2 Tabela planetas
CREATE TABLE Planetas
(
	nome VARCHAR(80),
	raio NUMERIC(10), -- Km
	populacao NUMERIC(20),
	tipo VARCHAR(20),
	raca VARCHAR(50),
	idioma VARCHAR(50),
	luas NUMERIC(5)
);

INSERT INTO Planetas (nome,raio,populacao,tipo,raca,idioma,luas)
VALUES('Kodora',59215,63570269,'Liquido','Trailxud','Xudaar',2),
('Sotelia',6371,15993297,'Floresta','Zeex','Ex',5),
('Nanus',372,71701,'Congeldo','Qhox','',20),
('Tromia C',32124,54262584,'Arenoso','Yastil','',1),
('Tivaitis',9085,0,'Gasoso',null,null,7);

INSERT INTO PLANETAS (nome, raio, populacao, tipo, raca, idioma, luas)
VALUES('Kepler', 338478, 654989874, 'Gasoso', 'Keplerianos', 'Rashmagu', 8),
('Krypton', 254568, 654989874, 'Sólido', 'Kryptonianos', 'Askavir', 19),
('Oltak', 543198, 9871321, 'Líquido', 'Oltakonianos', 'Oltak', 3),
('Iavyr', 212321, 878963, 'Arenoso', 'Iavyrianos', 'Kliavyr', 9),
('Vulcano', 338478, 654989874, 'Árido', 'Vulcanianos', 'Vulcan', 93);

INSERT INTO Planetas (nome, raio, populacao, tipo, raca, idioma, luas)
VALUES ('Banton 5', 2500, 1159825, 'Gasoso', 'Bantonions', 'Gowron', 15),
('Alkonost', 92169, 1213, 'Liquido', 'Alkens', 'Divok', 70),
('Orvim', 693268, 63287405, 'Vulcanico', 'Orvimian', 'XolV', 3),
('Thryavera', 74120, 58741290, 'Congelado', 'Thryavians', 'Mercpid', 31),
('Harklax Zeta', 41298750, 69745, 'Arenoso', 'harZetas', 'Harkkail', 7);

INSERT INTO PLANETAS(nome, raio, populacao, tipo, raca, idioma, luas)
VALUES ('Kylain', 4523681, 5600000000, 'Solido', 'Kylainianos', 'Kaylado', 20),
('Thrilly', 751, 3625, 'Aerenoso', 'Thrillynianos', 'Cleber', 0),
('Zeerth', 745216596, 963581, 'Liquido', 'Zeerthnianos', 'Ambar-64', 4),
('Thrai', 42994, 26359, 'Gasoso', 'Thrainianos', 'Ish', 0),
('Eghtfre', 8563293, 85462362, 'Solido', 'Eghtfrenianos', 'Alesk', 7);

SELECT * FROM Planetas;
