/*
Desafio
Em uma empresa que lidera projetos de Transformação Digital utilizando .NET e Inteligência Artificial, você faz parte da equipe de desenvolvedores responsável pelo motor de sugestões inteligentes do sistema. Esse motor recebe comandos dos usuários para registrar e remover sugestões tecnológicas, e ao final de cada interação, precisa apresentar as sugestões da lista, em ordem alfabética, para futura análise do algoritmo de IA.

Implemente um programa que processe uma sequência de comandos sobre uma lista de sugestões. Cada comando será “ADD ” para adicionar uma sugestão à lista, ou “REMOVE ” para remover. Após processar todos os comandos recebidos, seu programa deve exibir, em uma única linha, as sugestões restantes, separadas por espaços, ordenadas alfabeticamente. Se a lista estiver vazia, exiba apenas a palavra “VAZIO”.

Entrada
A primeira linha contém um número inteiro N, representando a quantidade de comandos.
As próximas N linhas contêm comandos no formato:
“ADD sugestao” ou “REMOVE sugestao”, onde “sugestao” é um texto sem espaços.

Saída
Exiba as sugestões restantes da lista em ordem alfabética e separadas por espaço, em uma única linha. Caso não haja sugestões, imprima "VAZIO".

Exemplos
A tabela abaixo apresenta exemplos de entrada e saída:
Entrada: 
3
ADD chatbot
ADD cloud
REMOVE chatbot
Saída:
cloud

Entrada:
2
ADD mlapi
REMOVE mlapi
Saída:
VAZIO

Entrada:
4
ADD iot
ADD azure
ADD bot
REMOVE iot
Saída:
azure bot
*/

//============================================================
// CÓDIGO BASE (NÃO FUNCIONAL)

// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         // Lê o número de comandos a serem processados
//         int n = int.Parse(Console.ReadLine());

//         // Inicializa a estrutura para armazenar sugestões únicas
//         HashSet<string> sugestoes = new HashSet<string>(StringComparer.Ordinal);

//         for (int i = 0; i < n; i++)
//         {
//             string linha = Console.ReadLine();

//             // Divide o comando em ação (ADD/REMOVE) e sugestão
//             int spaceIdx = linha.IndexOf(' ');
//             string acao = linha.Substring(0, spaceIdx);
//             string sugestao = linha.Substring(spaceIdx + 1);

//             // TODO: Implemente o tratamento para as ações de adicionar e remover sugestões
//             // Dica: utilize os métodos disponíveis na estrutura HashSet para gerenciar as sugestões
//         }

//         // Ao final, exibe as sugestões em ordem alfabética separadas por espaço,
//         // ou "VAZIO" se não houver elementos restantes
//         if (sugestoes.Count == 0)
//         {
//             Console.WriteLine("VAZIO");
//         }
//         else
//         {
//             List<string> ordenadas = sugestoes.ToList();
//             ordenadas.Sort(StringComparer.Ordinal);
//             Console.WriteLine(string.Join(" ", ordenadas));
//         }
//     }
// }

//============================================================
// RESOLUÇÃO 1 
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lê o número de comandos, com verificação de nulidade e vazio
        Console.WriteLine("Digite o número de comandos:");
        string inputN = Console.ReadLine() ?? "";
        if (string.IsNullOrWhiteSpace(inputN)) return; // Evita ArgumentNullException e FormatException
        int n = int.Parse(inputN);

        // Inicializa HashSet
        HashSet<string> sugestoes = new HashSet<string>(StringComparer.Ordinal);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite o comando:");
            string linha = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(linha)) continue; // Pula linhas vazias

            // Divide o comando usando Split (mais simples que Substring)
            string[] partes = linha.Split(' ');
            if (partes.Length != 2) continue; // Ignora comandos malformados
            string acao = partes[0];
            string sugestao = partes[1];

            // Implementa lógica de ADD/REMOVE
            if (acao == "ADD")
            {
                sugestoes.Add(sugestao); // Adiciona se único
            }
            else if (acao == "REMOVE")
            {
                sugestoes.Remove(sugestao); // Remove se existir
            }
        }

        // Saída final
        if (sugestoes.Count == 0)
        {
            Console.WriteLine("VAZIO");
        }
        else
        {
            List<string> ordenadas = new List<string>(sugestoes);
            ordenadas.Sort(StringComparer.Ordinal);
            Console.WriteLine(string.Join(" ", ordenadas));
        }
    }
}

//============================================================
// RESOLUÇÃO 2

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Lê o número de comandos, com verificação de nulidade
//         string inputN = Console.ReadLine();
//         if (inputN == null) return; // Evita ArgumentNullException
//         int n = int.Parse(inputN);

//         // Inicializa HashSet simplificado (C# 9+)
//         HashSet<string> sugestoes = new(StringComparer.Ordinal);

//         for (int i = 0; i < n; i++)
//         {
//             string linha = Console.ReadLine();
//             if (linha == null) continue; // Pula linhas nulas

//             // Divide o comando usando Split (mais simples que Substring)
//             string[] partes = linha.Split(' ');
//             if (partes.Length != 2) continue; // Ignora comandos malformados
//             string acao = partes[0];
//             string sugestao = partes[1];

//             // Implementa lógica de ADD/REMOVE
//             if (acao == "ADD")
//             {
//                 sugestoes.Add(sugestao); // Adiciona se único
//             }
//             else if (acao == "REMOVE")
//             {
//                 sugestoes.Remove(sugestao); // Remove se existir
//             }
//         }

//         // Saída final
//         if (sugestoes.Count == 0)
//         {
//             Console.WriteLine("VAZIO");
//         }
//         else
//         {
//             List<string> ordenadas = sugestoes.ToList();
//             ordenadas.Sort(StringComparer.Ordinal);
//             Console.WriteLine(string.Join(" ", ordenadas));
//         }
//     }
// }