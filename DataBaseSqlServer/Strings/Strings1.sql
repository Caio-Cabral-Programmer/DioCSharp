-- Consulta para listar produtos com seus nomes e cores, com concatenação de strings
SELECT Nome + ', Cor: ' + Cor NomeProduto FROM Produtos

-- Consulta para listar produtos com seus nomes e cores, utilizando funções UPPER e LOWER
SELECT Nome + ', Cor: ' + Cor NomeProduto,
UPPER(Nome) NomeUPPER,
LOWER(Cor) corLower
FROM Produtos

-- Consulta para listar produtos com seus nomes, cores e data de cadastro formatada
SELECT Nome + ', Cor: ' + Cor NomeProduto,
UPPER(Nome) NomeUPPER,
LOWER(Cor) corLower,
FORMAT(DataCadastro, 'dd/MM/yyyy') DATA
FROM Produtos