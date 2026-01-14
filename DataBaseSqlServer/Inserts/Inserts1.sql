-- Inserts para a tabela Clientes
INSERT INTO Clientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro) VALUES
('Leonardo', 'Buta', 'leonardo.buta@example.com', 1, GETDATE());

-- Verificação do insert
SELECT * FROM Clientes WHERE Nome = 'Leonardo';

-- Inserts para a tabela Clientes - Insert mais enxuto, porém menos explícito
INSERT INTO Clientes VALUES ('Leonardo', 'Buta', 'leonardo.buta@example.com', 1, GETDATE());