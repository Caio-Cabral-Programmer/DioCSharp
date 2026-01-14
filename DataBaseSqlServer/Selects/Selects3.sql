-- Estamos selecionando todos os campos das tabelas Clientes e Enderecos
-- onde o Id do cliente é igual a 4, utilizando um INNER JOIN
SELECT 
    * 
FROM 
    Clientes
INNER JOIN 
    Enderecos ON Clientes.Id = Enderecos.IdCliente
WHERE 
    Clientes.Id = 4

-- Agora, selecionamos apenas os campos Nome, Rua, Cidade e Estado
-- das tabelas Clientes e Enderecos para o cliente com Id igual a 4
SELECT 
    Clientes.Nome, 
    Enderecos.Rua, 
    Enderecos.Cidade, 
    Enderecos.Estado
FROM 
    Clientes
INNER JOIN 
    Enderecos ON Clientes.Id = Enderecos.IdCliente
WHERE 
    Clientes.Id = 4

-- Utilizando alias para as tabelas para tornar o código mais legível, porém menos explícito
SELECT 
    C.Nome, 
    E.Rua, 
    E.Cidade, 
    E.Estado
FROM 
    Clientes C
INNER JOIN 
    Enderecos E ON C.Id = E.IdCliente
WHERE 
    C.Id = 4

-- Utilizando LEFT JOIN para garantir que todos os clientes sejam retornados,
-- mesmo que não tenham um endereço associado
SELECT 
    C.Nome, 
    E.Rua, 
    E.Cidade, 
    E.Estado
FROM 
    Clientes C
LEFT JOIN 
    Enderecos E ON C.Id = E.IdCliente

-- Ordenando os resultados pela rua em ordem decrescente
SELECT 
    C.Nome, 
    E.Rua, 
    E.Cidade, 
    E.Estado
FROM 
    Clientes C
LEFT JOIN 
    Enderecos E ON C.Id = E.IdCliente
ORDER BY 
    E.Rua DESC