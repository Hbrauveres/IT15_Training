CREATE TABLE Medicos
(
	crm		CHAR(13) NOT NULL,
	nome	VARCHAR(50) NOT NULL,
	especialidade VARCHAR(50),

	CONSTRAINT PK_MEDICOS PRIMARY KEY (crm)
);

CREATE TABLE Pessoas
(
	cpf		CHAR(11) NOT NULL,
	nome	VARCHAR(50) NOT NULL,
	sexo	CHAR(1),

	CONSTRAINT PK_PESSOAS PRIMARY KEY (cpf),
	CONSTRAINT CK_SEXO CHECK (sexo IN ('M','F'))
);

CREATE TABLE MedicosPacientes
(
	crm		CHAR(13) NOT NULL,
	cpf		CHAR(11) NOT NULL,

	CONSTRAINT PK_MEDPAC PRIMARY KEY (crm,cpf),
	CONSTRAINT FK_CRM FOREIGN KEY (crm) REFERENCES Medicos(crm),
	CONSTRAINT FK_CPF FOREIGN KEY (cpf) REFERENCES Pessoas(cpf)
);

CREATE TABLE Consultas
(
	id			 CHAR(6) NOT NULL,
	crm			 CHAR(13) NOT NULL,
	cpf			 CHAR(11) NOT NULL,
	dataConsulta DATETIME NOT NULL,
	descricao	 VARCHAR(200),

	CONSTRAINT PK_CONSULTAS PRIMARY KEY (id),
	CONSTRAINT FK_CRM_CPF FOREIGN KEY (crm,cpf) REFERENCES MedicosPacientes(crm,cpf)
);

INSERT INTO Medicos(crm,nome,especialidade) VALUES('4707425298509','Cecília Giovana da Mata','Geriatra');
INSERT INTO Medicos(crm,nome,especialidade) VALUES('2320432013224','Cláudia Vanessa Dias','Anestesista');
INSERT INTO Medicos(crm,nome,especialidade) VALUES('4659882098598','Diogo Breno Renato da Rocha','Dermatologista');
INSERT INTO Medicos(crm,nome,especialidade) VALUES('8910154756510','Augusto Fábio Ribeiro','Ortopedista');
INSERT INTO Medicos(crm,nome,especialidade) VALUES('7652253047269','Benjamin Thiago Silveira','Neurologista');

INSERT INTO Pessoas(cpf, nome, sexo) VALUES('96732519670','Sara Vitória Duarte','F');
INSERT INTO Pessoas(cpf, nome, sexo) VALUES('02850506303','Vanessa Mariane Mariane Assis','F');
INSERT INTO Pessoas(cpf, nome, sexo) VALUES('69116760700','Tereza Benedita Isabelle Santos','F');
INSERT INTO Pessoas(cpf, nome, sexo) VALUES('14353848496','Carlos Eduardo Manuel Pinto','M');
INSERT INTO Pessoas(cpf, nome, sexo) VALUES('76121782811','Victor Diogo Bernardes','M');

INSERT INTO MedicosPacientes(crm,cpf) VALUES('4659882098598','96732519670');
INSERT INTO MedicosPacientes(crm,cpf) VALUES('4707425298509','76121782811');
INSERT INTO MedicosPacientes(crm,cpf) VALUES('8910154756510','69116760700');
INSERT INTO MedicosPacientes(crm,cpf) VALUES('7652253047269','02850506303');
INSERT INTO MedicosPacientes(crm,cpf) VALUES('8910154756510','02850506303');
INSERT INTO MedicosPacientes(crm,cpf) VALUES('4659882098598','14353848496');
INSERT INTO MedicosPacientes(crm,cpf) VALUES('4659882098598','69116760700');
INSERT INTO MedicosPacientes(crm,cpf) VALUES('7652253047269','76121782811');
INSERT INTO MedicosPacientes(crm,cpf) VALUES('8910154756510','96732519670');

INSERT INTO Consultas(id,crm,cpf, dataConsulta) VALUES('1','4659882098598','96732519670',CONVERT(varchar, '2021-07-17',103));
INSERT INTO Consultas(id,crm,cpf, dataConsulta) VALUES('2','7652253047269','02850506303',CONVERT(varchar, '2020-06-12',103));
INSERT INTO Consultas(id,crm,cpf, dataConsulta) VALUES('3','4659882098598','14353848496',CONVERT(varchar, '2022-05-12',103));
INSERT INTO Consultas(id,crm,cpf, dataConsulta) VALUES('4','4659882098598','69116760700',CONVERT(varchar, '2020-11-25',103));
INSERT INTO Consultas(id,crm,cpf, dataConsulta) VALUES('5','4707425298509','76121782811',CONVERT(varchar, '2021-11-15',103));
INSERT INTO Consultas(id,crm,cpf, dataConsulta) VALUES('6','8910154756510','96732519670',CONVERT(varchar, '2021-02-27',103));
INSERT INTO Consultas(id,crm,cpf, dataConsulta) VALUES('7','4707425298509','76121782811',CONVERT(varchar, '2021-02-02',103));
INSERT INTO Consultas(id,crm,cpf, dataConsulta) VALUES('8','7652253047269','76121782811',CONVERT(varchar, '2021-01-20',103));
INSERT INTO Consultas(id,crm,cpf, dataConsulta) VALUES('9','8910154756510','69116760700',CONVERT(varchar, '2021-06-05',103));
INSERT INTO Consultas(id,crm,cpf, dataConsulta) VALUES('10','4659882098598','69116760700',CONVERT(varchar, '2020-07-01',103));
INSERT INTO Consultas(id,crm,cpf, dataConsulta) VALUES('11','8910154756510','96732519670',CONVERT(varchar, '2021-03-16',103));
INSERT INTO Consultas(id,crm,cpf, dataConsulta) VALUES('12','4707425298509','76121782811',CONVERT(varchar, '2021-06-25',103));
INSERT INTO Consultas(id,crm,cpf, dataConsulta) VALUES('13','8910154756510','02850506303',CONVERT(varchar, '2022-05-15',103));

SELECT * FROM Medicos;
SELECT * FROM Pessoas;
SELECT * FROM MedicosPacientes;
SELECT id,crm,cpf, FORMAT(dataConsulta,'dd/MM/yyyy') as date FROM Consultas;
