SELECT * FROM Clientes WHERE Nome = 'Leonardo';

DELETE Clientes
WHERE Id = 1001;

-- DELETE sem WHERE - CUIDADO! Apaga todos os registros da tabela. Mas foi colocado dentro de uma transação para evitar alterações permanentes
SELECT * FROM Clientes
BEGIN TRAN -- Isso inicia uma transação e possibilita o ROLLBACK
DELETE Clientes -- Apaga todos os registros da tabela
ROLLBACK -- Isso desfaz todas as alterações feitas na transação