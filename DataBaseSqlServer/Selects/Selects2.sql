-- Consulta para contar a quantidade de produtos por tamanho, utilizando GROUP BY, que faz a agregação dos dados com base na coluna Tamanho
-- Group By faz exatamente o seguinte → Agrupa os dados iguais de acordo com a coluna especificada, permitindo que funções de agregação, como COUNT, SUM, AVG, MAX, MIN, sejam aplicadas a cada grupo individualmente.
SELECT Tamanho,
         COUNT(*) AS Quantidade
FROM Produtos
GROUP BY Tamanho

-- Consulta para contar a quantidade de produtos por tamanho, excluindo os registros onde o tamanho é uma string vazia
SELECT Tamanho,
         COUNT(*) AS Quantidade
FROM Produtos
WHERE Tamanho <> '' -- <> significa "diferente de", semelhante ao !=
GROUP BY Tamanho

-- Consulta para contar a quantidade de produtos por tamanho, excluindo os registros onde o tamanho é uma string vazia e ordenando os resultados pela quantidade em ordem decrescente
SELECT Tamanho,
         COUNT(*) AS Quantidade
FROM Produtos
WHERE Tamanho != '' -- também significa "diferente de"
GROUP BY Tamanho
ORDER BY Quantidade DESC -- Ordena os resultados pela quantidade em ordem decrescente