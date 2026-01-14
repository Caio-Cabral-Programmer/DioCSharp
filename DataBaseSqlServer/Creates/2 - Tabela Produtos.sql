DROP TABLE IF EXISTS dbo.Produtos

CREATE TABLE Produtos (
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL, -- 1,1 → significa que o valor inicia em 1 e incrementa de 1 em 1. Primary Key → significa que este campo é a chave primária da tabela e não pode haver valores repetidos
	Nome varchar(255) NOT NULL, -- NOT NULL → significa que este campo é obrigatório
	Cor varchar(50) NULL, -- NULL → significa que este campo é opcional, ou seja, pode ficar vazio
	Preco decimal(13, 2) NOT NULL, -- decimal(13,2) → significa que o campo aceita números com até 13 dígitos, sendo 2 deles após a vírgula
	Tamanho varchar(5) NULL, -- varchar(5) → significa que o campo aceita até 5 caracteres
	Genero char(1) NULL -- char(1) → significa que o campo aceita exatamente 1 caractere, provavelmente uma sigla (M, F, U)
)

INSERT INTO Produtos VALUES ('Mountain Bike Socks, M','Branco','9.50','M','U')
INSERT INTO Produtos VALUES ('Mountain Bike Socks, L','Branco','9.50','G','U')
INSERT INTO Produtos VALUES ('AWC Logo Cap','Colorido','8.99','','U')
INSERT INTO Produtos VALUES ('Long-Sleeve Logo Jersey, S','Colorido','49.99','P','U')
INSERT INTO Produtos VALUES ('Long-Sleeve Logo Jersey, M','Colorido','49.99','M','U')
INSERT INTO Produtos VALUES ('Long-Sleeve Logo Jersey, L','Colorido','49.99','G','U')
INSERT INTO Produtos VALUES ('Long-Sleeve Logo Jersey, XL','Colorido','49.99','GG','U')
INSERT INTO Produtos VALUES ('Mens Sports Shorts, S','Preto','59.99','P','M')
INSERT INTO Produtos VALUES ('Mens Sports Shorts, M','Preto','59.99','M','M')
INSERT INTO Produtos VALUES ('Mens Sports Shorts, L','Preto','59.99','G','M')
INSERT INTO Produtos VALUES ('Mens Sports Shorts, XL','Preto','59.99','GG','M')
INSERT INTO Produtos VALUES ('Womens Tights, S','Preto','74.99','P','F')
INSERT INTO Produtos VALUES ('Womens Tights, M','Preto','74.99','M','F')
INSERT INTO Produtos VALUES ('Womens Tights, L','Preto','74.99','G','F')
INSERT INTO Produtos VALUES ('Mens Bib-Shorts, S','Colorido','89.99','P','M')
INSERT INTO Produtos VALUES ('Mens Bib-Shorts, M','Colorido','89.99','M','M')
INSERT INTO Produtos VALUES ('Mens Bib-Shorts, L','Colorido','89.99','G','M')
INSERT INTO Produtos VALUES ('Half-Finger Gloves, S','Preto','24.49','P','U')
INSERT INTO Produtos VALUES ('Half-Finger Gloves, M','Preto','24.49','M','U')
INSERT INTO Produtos VALUES ('Half-Finger Gloves, L','Preto','24.49','G','U')
INSERT INTO Produtos VALUES ('Full-Finger Gloves, S','Preto','37.99','P','U')
INSERT INTO Produtos VALUES ('Full-Finger Gloves, M','Preto','37.99','M','U')
INSERT INTO Produtos VALUES ('Full-Finger Gloves, L','Preto','37.99','G','U')
INSERT INTO Produtos VALUES ('Classic Vest, S','Blue','63.50','P','U')
INSERT INTO Produtos VALUES ('Classic Vest, M','Blue','63.50','M','U')
INSERT INTO Produtos VALUES ('Classic Vest, L','Blue','63.50','G','U')
INSERT INTO Produtos VALUES ('Womens Mountain Shorts, S','Preto','69.99','P','F')
INSERT INTO Produtos VALUES ('Womens Mountain Shorts, M','Preto','69.99','M','F')
INSERT INTO Produtos VALUES ('Womens Mountain Shorts, L','Preto','69.99','G','F')
INSERT INTO Produtos VALUES ('Racing Socks, M','Branco','8.99','M','U')
INSERT INTO Produtos VALUES ('Racing Socks, L','Branco','8.99','G','U')
INSERT INTO Produtos VALUES ('Short-Sleeve Classic Jersey, S','Amarelo','53.99','P','U')
INSERT INTO Produtos VALUES ('Short-Sleeve Classic Jersey, M','Amarelo','53.99','M','U')
INSERT INTO Produtos VALUES ('Short-Sleeve Classic Jersey, L','Amarelo','53.99','G','U')
INSERT INTO Produtos VALUES ('Short-Sleeve Classic Jersey, XL','Amarelo','53.99','GG','U')