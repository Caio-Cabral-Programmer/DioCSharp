SELECT * FROM Produtos

-- Adicionar a coluna DataCadastro do tipo DATETIME2 na tabela Produtos
ALTER TABLE Produtos
ADD DataCadastro DATETIME2

-- Remover a coluna DataCadastro da tabela Produtos
ALTER TABLE Produtos
DROP COLUMN DataCadastro

-- Atualizar a coluna DataCadastro com a data e hora atual para todos os registros existentes
UPDATE Produtos SET DataCadastro = GETDATE()