USE SENAI_HROADS_MANHA;
GO

INSERT INTO Personagem(idClasse,nome,capVida,capMana,dataAtt,dataCriacao)
VALUES (1,'DeuBug',100,80,'2021-09-17','2019-01-18');
GO

INSERT INTO Personagem(idClasse,nome,capVida,capMana,dataAtt,dataCriacao)
VALUES (4,'BitBug',70,100,'2021-09-17','2016-03-17');
GO

INSERT INTO Personagem(idClasse,nome,capVida,capMana,dataAtt,dataCriacao)
VALUES (7,'Fer8',75,60,'2021-09-17','2018-03-18');
GO

INSERT INTO Classe(nomeClasse)
VALUES ('Bárbaro'),('Cruzado'),('Caçadora de Demônios'),('Monge'),('Necromante'),('Feiticeiro'),('Arcanista');
GO

INSERT INTO Tipo_Habilidade(nomeTipoHabilidade)
VALUES ('Ataque'),('Defesa'),('Cura'),('Magia');
GO

INSERT INTO Habilidade(idTipoHabilidade,nomeHabilidade)
VALUES (1,'Lança Mortal');
GO

INSERT INTO Habilidade(idTipoHabilidade,nomeHabilidade)
VALUES (2,'Escudo Supremo');
GO

INSERT INTO Habilidade(idTipoHabilidade,nomeHabilidade)
VALUES (3,'Recuperar Vida');
GO

INSERT INTO Usuario(nomeJogador,email,senha)
VALUES ('CardosinhoGameplay','cardoso@gmail.com','1234');
GO

INSERT INTO Usuario(nomeJogador,email,senha)
VALUES ('Ricardortc','ricardo@gmail.com','12345');
GO

INSERT INTO Usuario(nomeJogador,email,senha)
VALUES ('Sauloxiter','saulo@gmail.com','123456');
GO

INSERT INTO TipoUsuario(idUsuario,titulo)
VALUES ('1','Usuario')
GO

INSERT INTO TipoUsuario(idUsuario,titulo)
VALUES ('2','Usuario')
GO

INSERT INTO TipoUsuario(idUsuario,titulo)
VALUES ('3','Adm')
GO


UPDATE Personagem
SET nome = 'Fer7'
WHERE idPersonagem = 6

UPDATE Classe
SET nomeClasse = 'Necromancer'
WHERE idClasse = 5

SELECT * FROM Personagem;
SELECT * FROM Habilidade;
SELECT * FROM Classe;
SELECT * FROM Usuario;
SELECT * FROM TipoUsuario;