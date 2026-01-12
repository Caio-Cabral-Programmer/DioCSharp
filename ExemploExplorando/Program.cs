using System.Globalization;
using ExemploExplorando.Models;

// ============================================================
// INSTANCIAÇÃO DE OBJETOS
// Criando objetos usando o construtor com parâmetros
Console.WriteLine("=== INSTANCIAÇÃO DE OBJETOS ===");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("- Instanciação de objetos usando construtor com parâmetros");
Console.WriteLine();

Pessoa p1 = new("Caio", "Cabral", 30);
Pessoa p2 = new("Ana", "Silva", 25);

Curso cursoCSharp = new()
{
    Nome = "C# Básico",
    Alunos = new List<Pessoa>() // Poderia ser mais simples: Alunos = []
};

cursoCSharp.AdicionarAluno(p1);
cursoCSharp.AdicionarAluno(p2);

cursoCSharp.ListarAlunos();

// Instanciação de objetos - forma tradicional
Console.WriteLine();
Console.WriteLine("- Instanciação de objetos - forma tradicional");
Console.WriteLine();

Pessoa p3 = new();
p3.Nome = "Caio";
p3.Idade = 30;
p3.Sobrenome = "Cabral";
p3.Apresentar();

// Instantiação de objetos - forma simplificada
Console.WriteLine();
Console.WriteLine("- Instantiação de objetos - forma simplificada");
Console.WriteLine();

Pessoa p4 = new()
{
    Nome = "Caio",
    Idade = 28,
};
p4.Apresentar();

// Criando objetos usando o construtor com parâmetros, porém de modo mais explicito
Console.WriteLine();
Console.WriteLine("- Criando objetos usando o construtor com parâmetros, porém de modo mais explícito");
Console.WriteLine();

Pessoa p5 = new(nome: "Caio", sobrenome: "Cabral", idade: 30);
Pessoa p6 = new(nome: "Ana", sobrenome: "Silva", idade: 25);
p5.Apresentar();
p6.Apresentar();


// ============================================================
// FORMATAÇÃO DE VALORES MONETÁRIOS
Console.WriteLine();
Console.WriteLine("=== FORMATAÇÃO DE VALORES MONETÁRIOS ===");
Console.WriteLine();

// Formatação padrão
Console.WriteLine();
Console.WriteLine("- Formatação padrão");
Console.WriteLine();

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); // Define a cultura padrão deste código para pt-BR

decimal valorMonetario = 1580.40m;
Console.WriteLine($"Valor monetário (formato padrão): {valorMonetario}");
Console.WriteLine($"Valor monetário (formato moeda da configuração do sistema): {valorMonetario:C}"); // Pega a cultura padrão do sistema ou que foi definida no código como DefaultThreadCurrentCulture
Console.WriteLine($"Valor monetário (formato moeda - pt-BR): {valorMonetario.ToString("C", new CultureInfo("pt-BR"))}");
Console.WriteLine($"Valor monetário (formato moeda - en-US): {valorMonetario.ToString("C", new CultureInfo("en-US"))}");


// ============================================================
// FORMATAÇÃO PERSONALIZADA
Console.WriteLine();
Console.WriteLine("=== FORMATAÇÃO PERSONALIZADA ===");
Console.WriteLine();


// Formatação personalizada de valores monetários
Console.WriteLine();
Console.WriteLine("- Formatação personalizada de valores monetários");
Console.WriteLine();

decimal valorMonetario2 = 1580.40m;
Console.WriteLine(valorMonetario2.ToString("C0", new CultureInfo("pt-BR"))); // Sem casas decimais
Console.WriteLine(valorMonetario2.ToString("C1", new CultureInfo("pt-BR"))); // 1 casa decimal
Console.WriteLine(valorMonetario2.ToString("C2", new CultureInfo("pt-BR"))); // 2 casas decimais
Console.WriteLine(valorMonetario2.ToString("C3", new CultureInfo("pt-BR"))); // 3 casas decimais
Console.WriteLine(valorMonetario2.ToString("N3", new CultureInfo("pt-BR"))); // Número com 3 casas decimais, sem o símbolo monetário
Console.WriteLine(valorMonetario2.ToString("F1", new CultureInfo("pt-BR"))); // Número fixo com 1 casa decimal, sem o símbolo monetário

// Formatação personalizada de porcentagens
Console.WriteLine();
Console.WriteLine("- Formatação personalizada de porcentagens");
Console.WriteLine();

decimal valorPorcentagem = 0.15m;
Console.WriteLine(valorPorcentagem.ToString("P0", new CultureInfo("pt-BR"))); // Sem casas decimais
Console.WriteLine(valorPorcentagem.ToString("P1", new CultureInfo("pt-BR"))); // 1 casa decimal
Console.WriteLine(valorPorcentagem.ToString("P2", new CultureInfo("pt-BR"))); // 2 casas decimais

double porcentagem = 0.1534;
Console.WriteLine(porcentagem.ToString("P")); // Formato padrão com 2 casas decimais

// Formatação personalizada com separadores
Console.WriteLine();
Console.WriteLine("- Formatação personalizada com separadores");
Console.WriteLine();

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));


// ============================================================
// FORMATAÇÃO DATETIME
Console.WriteLine();
Console.WriteLine("=== FORMATAÇÃO DATETIME ===");
Console.WriteLine();

// Formatação padrão
Console.WriteLine();
Console.WriteLine("- Formatação padrão");
Console.WriteLine();

DateTime dataAtual = DateTime.Now;
Console.WriteLine($"Data atual (formato padrão): {dataAtual}");
Console.WriteLine($"Data atual (formato curto): {dataAtual.ToShortDateString()}");
Console.WriteLine($"Data atual (formato curto): {dataAtual:d}");
Console.WriteLine($"Data atual (formato longo): {dataAtual.ToLongDateString()}");
Console.WriteLine($"Data atual (formato longo): {dataAtual:D}");
Console.WriteLine($"Data atual (formato longo): {dataAtual.ToShortTimeString()}");
Console.WriteLine($"Data atual (formato longo): {dataAtual:t}");
Console.WriteLine($"Data atual (formato longo): {dataAtual.ToLongTimeString()}");
Console.WriteLine($"Data atual (formato longo): {dataAtual:T}");
Console.WriteLine($"Data atual (formato personalizado): {dataAtual.ToString("dd/MM/yyyy HH:mm")}");

// Conversão de string para DateTime
Console.WriteLine();
Console.WriteLine("- Conversão de string para DateTime");
Console.WriteLine();

string dataString = "2024-06-15 14:30";
DateTime dataConvertida = DateTime.Parse(dataString);
DateTime dataConvertida2 = DateTime.Parse(dataString, CultureInfo.InvariantCulture);
Console.WriteLine($"Data convertida: {dataConvertida.ToString("dd/MM/yyyy HH:mm")}");
Console.WriteLine($"Data convertida: {dataConvertida:dd/MM/yyyy HH:mm}");
Console.WriteLine($"Data convertida2: {dataConvertida2.ToString("dd/MM/yyyy HH:mm")}");
Console.WriteLine($"Data convertida2: {dataConvertida2:dd/MM/yyyy HH:mm}");

// Conversão de string para DateTime com TryParse
Console.WriteLine();
Console.WriteLine("- Conversão de string para DateTime com TryParse");
Console.WriteLine();

string dataString2 = "2024-15-06 14:30";
bool sucesso = DateTime.TryParse(dataString2, out DateTime dataResultado);

if (sucesso)
{
    Console.WriteLine($"Data convertida com sucesso: {dataResultado:dd/MM/yyyy HH:mm}");
}
else
{
    Console.WriteLine("Falha na conversão da data.");
}

string dataString3 = "2024-15-06 14:30";
bool sucesso2 = DateTime.TryParseExact(dataString3, 
                                        "yyyy-MM-dd HH:mm", 
                                        CultureInfo.InvariantCulture, 
                                        DateTimeStyles.None, 
                                        out DateTime dataResultado2);

if (sucesso2)
{
    Console.WriteLine($"Data convertida com sucesso: {dataResultado2:dd/MM/yyyy HH:mm}");
}
else
{
    Console.WriteLine($"Falha na conversão da data. String fornecida não é uma data válida: {dataString3}");
}


// ============================================================
// LEITURA DE ARQUIVO
Console.WriteLine();
Console.WriteLine("=== LEITURA DE ARQUIVO ===");
Console.WriteLine();

// Leitura de arquivo simples (pode estourar erro)
Console.WriteLine();
Console.WriteLine("- Leitura de arquivo simples");
Console.WriteLine();

string caminhoArquivo = "arquivoLeitura.txt"; // mude o caminho para testar a exceção
string[] linhasArquivo = File.ReadAllLines(caminhoArquivo);
foreach (string linha in linhasArquivo)
{
    Console.WriteLine(linha);
}

// Leitura de arquivo para evitar erros
Console.WriteLine();
Console.WriteLine("- Leitura de arquivo para evitar erros");
Console.WriteLine();

string caminhoArquivo2 = "arquivoLeitura.txt";
if (File.Exists(caminhoArquivo2))
{
    string[] linhas = File.ReadAllLines(caminhoArquivo2);
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine($"O arquivo '{caminhoArquivo2}' não foi encontrado.");
}

// Leitura de arquivo para evitar erros com Try-Catch
Console.WriteLine();
Console.WriteLine("- Leitura de arquivo para evitar erros com Try-Catch");
Console.WriteLine();

string caminhoArquivo3 = "arquivoLeitura.txt";
try
{
    string[] linhas2 = File.ReadAllLines(caminhoArquivo3);
    foreach (var linha in linhas2)
    {
        Console.WriteLine(linha);
    }
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Diretório não encontrado: {ex.Message}");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Tratamento genérico para exceções: {ex.Message}");
}
finally
{
    Console.WriteLine("finally sempre executa no bloco try-catch, capturando erros ou não.");
}

Console.WriteLine("Agora a execução do programa continua normalmente... Antes o programa parava quando havia uma exceção de arquivo não encontrado.");


// ============================================================
// TRATAMENTO DE EXCEÇÕES
Console.WriteLine();
Console.WriteLine("=== TRATAMENTO DE EXCEÇÕES ===");
Console.WriteLine();

// throw e seu uso
Console.WriteLine();
Console.WriteLine("- throw e seu uso");
Console.WriteLine();

new ExemploExcecao().Metodo1();


// ============================================================
// COLEÇÕES
Console.WriteLine();
Console.WriteLine("=== COLEÇÕES ===");
Console.WriteLine();

// List (Lista)
Console.WriteLine();
Console.WriteLine("- List (Lista)");
Console.WriteLine();

List<string> lista = new List<string>();
Console.WriteLine("Adicionando elementos...");
lista.Add("Primeiro");
lista.Add("Segundo");
lista.Add("Terceiro");
Console.WriteLine($"Elementos na lista: {lista.Count}");
Console.WriteLine("Elementos na lista:");
foreach (var item in lista)
{
    Console.WriteLine(item);
}
Console.WriteLine("Removendo o elemento 'Segundo'...");
lista.Remove("Segundo");
Console.WriteLine($"Elementos na lista após remoção: {lista.Count}");
Console.WriteLine("Elementos restantes na lista:");
foreach (var item in lista)
{
    Console.WriteLine(item);
}

// Queue (Fila)
Console.WriteLine();
Console.WriteLine("- Queue (Fila)");
Console.WriteLine();

Queue<string> fila = new Queue<string>();
Console.WriteLine("Adicionando elementos...");
fila.Enqueue("Primeiro");
fila.Enqueue("Segundo");
fila.Enqueue("Terceiro");

Console.WriteLine($"Elementos na fila: {fila.Count}");
Console.WriteLine($"Primeiro elemento da fila: {fila.Peek()}");
Console.WriteLine($"Removendo o primeiro elemento da fila: {fila.Dequeue()}");
Console.WriteLine($"Elementos na fila após remoção: {fila.Count}");

Console.WriteLine("Elementos restantes na fila:");
foreach (var item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine("Adicionando mais um elemento...");
fila.Enqueue("Quarto");
Console.WriteLine($"Elementos na fila após adição: {fila.Count}");
Console.WriteLine("Elementos na fila agora:");
foreach (var item in fila)
{
    Console.WriteLine(item);
}

// Stack (Pilha)
Console.WriteLine();
Console.WriteLine("- Stack (Pilha)");
Console.WriteLine();

Stack<string> pilha = new Stack<string>();
Console.WriteLine("Adicionando elementos...");
pilha.Push("Primeiro");
pilha.Push("Segundo");
pilha.Push("Terceiro");

Console.WriteLine($"Elementos na pilha: {pilha.Count}");
Console.WriteLine($"Primeiro elemento da pilha: {pilha.Peek()}");
Console.WriteLine($"Removendo o primeiro elemento da pilha: {pilha.Pop()}");
Console.WriteLine($"Elementos na pilha após remoção: {pilha.Count}");

Console.WriteLine("Elementos restantes na pilha:");
foreach (var item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine("Adicionando mais um elemento...");
pilha.Push("Quarto");
Console.WriteLine($"Elementos na pilha após adição: {pilha.Count}");
Console.WriteLine("Elementos na pilha agora:");
foreach (var item in pilha)
{
    Console.WriteLine(item);
}

// Dictionary (Dicionário)
Console.WriteLine();
Console.WriteLine("- Dictionary (Dicionário)");
Console.WriteLine();

Dictionary<int, string> dicionario = new Dictionary<int, string>();
Console.WriteLine("Adicionando elementos...");
dicionario.Add(1, "Primeiro");
dicionario.Add(2, "Segundo");
dicionario.Add(3, "Terceiro");
Console.WriteLine($"Elementos no dicionário: {dicionario.Count}");
Console.WriteLine($"Elemento com chave 2: {dicionario[2]}");
Console.WriteLine("Removendo o elemento com chave 2...");
dicionario.Remove(2);
Console.WriteLine($"Elementos no dicionário após remoção: {dicionario.Count}");
Console.WriteLine("Elementos restantes no dicionário [com var]:");
foreach (var item in dicionario)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("Elementos restantes no dicionário [com KeyValuePair]:");
foreach (KeyValuePair<int, string> item in dicionario)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("Elementos restantes no dicionário com um valor alterado:");
dicionario[3] = "Terceiro - Alterado";
foreach (var item in dicionario)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("Verificando elemento no dicionário:");
Console.WriteLine($"Chave 1 existe? {dicionario.ContainsKey(1)}");
Console.WriteLine($"Valor com chave 3 existe? {dicionario.ContainsValue("Terceiro - Alterado")}");

if (dicionario.TryGetValue(3, out string valorEncontrado))
{
    Console.WriteLine($"Valor encontrado para a chave 3: {valorEncontrado}");
}
else
{
    Console.WriteLine("Chave não encontrada.");
}

Console.WriteLine("Acessando valor pela chave:");
Console.WriteLine($"Valor para a chave 1: {dicionario[1]}");
Console.WriteLine($"Valor para a chave 3: {dicionario[3]}");

// HashSet (Conjunto)
Console.WriteLine();
Console.WriteLine("- HashSet (Conjunto)");
Console.WriteLine();

HashSet<string> conjunto = new HashSet<string>();
Console.WriteLine("Adicionando elementos...");
conjunto.Add("Elemento1");
conjunto.Add("Elemento2");
conjunto.Add("Elemento3");
conjunto.Add("Elemento1"); // Tentativa de adicionar duplicata
Console.WriteLine($"Elementos no conjunto: {conjunto.Count}");
Console.WriteLine("Elementos no conjunto:");
foreach (var item in conjunto)
{
    Console.WriteLine(item);
}

Console.WriteLine("Removendo o elemento 'Elemento2'...");
conjunto.Remove("Elemento2");
Console.WriteLine($"Elementos no conjunto após remoção: {conjunto.Count}");
Console.WriteLine("Elementos restantes no conjunto:");
foreach (var item in conjunto)
{
    Console.WriteLine(item);
}

        