-- UPDATE - Útil, mas muito perigoso se não for usado com critério adequado, pois pode atualizar todos os registros da tabela
-- DICA 1 - Faça um SELECT antes do UPDATE para garantir que o WHERE está correto
-- DICA 2 - Sempre use WHERE para evitar atualizar todos os registros da tabela

-- Atualiza o email e a preferência de comunicação do cliente com Id 1002
SELECT * FROM Clientes WHERE Id = 1002;

UPDATE Clientes
SET Email = 'emailatualizado@email.com',
    AceitaComunicados = 0
WHERE Id = 1002;

-- Atualiza o email e a preferência de comunicação do cliente com Nome 'Leonardo', ou seja, todos os clientes com esse nome
SELECT * FROM Clientes WHERE Nome = 'Leonardo';

UPDATE Clientes
SET Email = 'emailatualizado@email.com',
    AceitaComunicados = 0
WHERE Nome = 'Leonardo';

-- Update sem WHERE - CUIDADO! Atualiza todos os registros da tabela. Mas foi colocado dentro de uma transação para evitar alterações permanentes
SELECT * FROM Clientes;

BEGIN TRAN -- Isso dá possibilidade de dar um ROLLBACK depois
UPDATE Clientes
SET Email = 'emailatualizado@email.com',
    AceitaComunicados = 0,
    Sobrenome = 'BUTA2'

ROLLBACK; -- Desfaz as alterações feitas pelo UPDATE acima
