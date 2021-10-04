CREATE DATABASE hroads_senai;
GO

USE hroads_senai;
GO

CREATE TABLE Tipo_Habilidade(
	idTipoHabilidade INT PRIMARY KEY IDENTITY,
	nomeTipoHabilidade VARCHAR(50),
);
GO

CREATE TABLE Classe(
	idClasse INT PRIMARY KEY IDENTITY,
	nomeClasse VARCHAR(50),
); 
GO

CREATE TABLE Personagem(
	idPersonagem INT PRIMARY KEY IDENTITY,
	idClasse INT FOREIGN KEY REFERENCES Classe(idClasse),
	nome VARCHAR(50),
	capMana TINYINT,
	capVida TINYINT,
	dataAtt DATE,
	dataCriacao DATE
);
GO

CREATE TABLE Habilidade(
	idHabilidade INT PRIMARY KEY IDENTITY,
	idTipoHabilidade INT FOREIGN KEY REFERENCES Tipo_Habilidade(idTipoHabilidade),
	nomeHabilidade VARCHAR(100)
);
GO

CREATE TABLE TipoUsuario(
idTipoUsuario INT PRIMARY KEY IDENTITY,
titulo VARCHAR(200)
);
GO

CREATE TABLE Usuario(
idUsuario INT PRIMARY KEY IDENTITY,
idTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario(idTipoUsuario),
nomeJogador VARCHAR(200),
email VARCHAR(200),
senha VARCHAR(200)
);
GO

