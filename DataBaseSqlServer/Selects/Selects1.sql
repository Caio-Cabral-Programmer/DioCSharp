-- Consulta para obter todos os registros da tabela Clientes
SELECT * FROM Clientes;

-- Consulta para obter todos os registros da tabela Clientes ordenados por Nome
SELECT * FROM Clientes
ORDER BY Nome;

-- Consulta para obter todos os registros da tabela Clientes ordenados por Nome em ordem decrescente
SELECT * FROM Clientes
ORDER BY Nome DESC;

-- Consulta para obter todos os registros da tabela Clientes ordenados por Sobrenome
SELECT * FROM Clientes
ORDER BY Sobrenome;

-- Consulta para obter todos os registros da tabela Clientes ordenados primeiro por Nome e depois por Sobrenome
SELECT * FROM Clientes
ORDER BY Nome, Sobrenome;

-- Consulta para obter apenas os campos Nome, Sobrenome e Email da tabela Clientes
SELECT Nome, Sobrenome, Email FROM Clientes;

-- Consulta com filtro para obter apenas os registros onde o Nome é 'Adam'
SELECT * FROM Clientes
WHERE Nome = 'Adam'
ORDER BY Nome, Sobrenome;

-- Consulta com filtro para obter apenas os registros onde o Nome é 'Adam' e o Sobrenome é 'Reynolds'
SELECT * FROM Clientes
WHERE Nome = 'Adam' AND Sobrenome = 'Reynolds'
ORDER BY Nome, Sobrenome;

-- Consulta com filtro para obter apenas os registros onde o Nome é 'Adam' ou o Sobrenome é 'Reynolds'
SELECT * FROM Clientes
WHERE Nome = 'Adam' OR Sobrenome = 'Reynolds'
ORDER BY Nome, Sobrenome;

-- Consulta com filtro para obter apenas os registros onde o Nome começa com a letra 'G'
SELECT * FROM Clientes
WHERE Nome LIKE 'G%'
ORDER BY Nome, Sobrenome;

-- Consulta com filtro para obter apenas os registros onde o Nome contém a letra 'G'
SELECT * FROM Clientes
WHERE Nome LIKE '%G%'
ORDER BY Nome, Sobrenome;
