-- Script para criar a tabela Enderecos com chave estrangeira para a tabela Clientes
CREATE TABLE Enderecos (
    Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
    IdCliente INT NULL,
    Rua varchar(255) NULL,
    Bairro varchar(255) NULL,
    Cidade varchar(255) NULL,
    Estado char(2) NOT NULL,

    CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY (IdCliente)
    REFERENCES Clientes(Id)
)

 -- CONSTRAINT → Define uma restrição na tabela, que é uma regra que os dados devem seguir
-- FK_Enderecos_Clientes → Nome da restrição, que indica que é uma chave estrangeira (FK) entre as tabelas Enderecos e Clientes
-- FOREIGN KEY (IdCliente) → Define que a coluna IdCliente é uma chave estrangeira
-- REFERENCES Clientes(Id) → Indica que a chave estrangeira referencia a coluna Id da tabela Clientes

-- Exemplo de inserção de um endereço para um cliente existente
INSERT INTO Enderecos (IdCliente, Rua, Bairro, Cidade, Estado) VALUES (4, 'Rua A', 'Bairro A', 'Cidade A', 'SP')

SELECT * FROM Enderecos