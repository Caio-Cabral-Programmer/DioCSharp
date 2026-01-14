SELECT * FROM Produtos

-- Contar o número total de produtos na tabela
SELECT COUNT(*) FROM Produtos

-- Contar o número total de produtos na tabela com alias para a coluna
SELECT COUNT(*) QuantidadeProdutos FROM Produtos

-- Contar o número total de produtos 'M' na tabela com alias para a coluna
SELECT COUNT(*) QuantidadeProdutosM FROM Produtos WHERE Tamanho = 'M'

-- Calcular o preço total de todos os produtos na tabela com alias para a coluna
SELECT SUM(Preco) PrecoTotal FROM Produtos

-- Calcular o preço total dos produtos 'M' na tabela com alias para a coluna
SELECT SUM(Preco) PrecoTotal FROM Produtos WHERE Tamanho = 'M'

-- Encontrar o preço máximo de todos os produtos na tabela com alias para a coluna
SELECT MAX(Preco) PrecoMaximo FROM Produtos

-- Encontrar o preço máximo dos produtos 'M' na tabela com alias para a coluna
SELECT MAX(Preco) PrecoMaximo FROM Produtos WHERE Tamanho = 'M'

-- Encontrar o preço mínimo de todos os produtos na tabela com alias para a coluna
SELECT MIN(Preco) PrecoMinimo FROM Produtos

-- Encontrar o preço mínimo dos produtos 'M' na tabela com alias para a coluna
SELECT MIN(Preco) PrecoMinimo FROM Produtos WHERE Tamanho = 'M'

-- Calcular o preço médio de todos os produtos na tabela com alias para a coluna
SELECT AVG(Preco) PrecoMedio FROM Produtos


