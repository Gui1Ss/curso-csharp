# Listas e Busca com `FindAll` (C#)

Este projeto demonstra como utilizar a coleção `List<T>` em C#, adicionando elementos, percorrendo a lista com `foreach` e filtrando resultados utilizando o método `FindAll()`.

## Objetivo

Praticar os seguintes conceitos da linguagem C#:

* Criação de `List<string>`
* Adição de elementos com `Add()`
* Percorrer listas com `foreach`
* Filtragem utilizando expressões lambda
* Método `FindAll()`

## Código

```csharp
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___ListaNull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> clientes = new List<string>();

            clientes.Add("Guilherme");
            clientes.Add("Souto");

            string pessoa = "José";
            clientes.Add(pessoa);

            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            // string busca = clientes.Find(cliente => cliente.Length > 14);

            List<string> filtrada = clientes.FindAll(cliente => cliente.Length > 4);

            Console.WriteLine("=======================");

            foreach (string cliente in filtrada)
            {
                Console.WriteLine(cliente);
            }

            Console.ReadLine();
        }
    }
}
```

## Como o programa funciona

O programa cria uma lista de clientes e adiciona três nomes:

* Guilherme
* Souto
* José

Depois disso, ele:

1. Exibe todos os nomes cadastrados.
2. Filtra apenas os nomes que possuem **mais de 4 caracteres** usando `FindAll()`.
3. Exibe a nova lista filtrada.

## Exemplo de saída

```text
Guilherme
Souto
José
=======================
Guilherme
Souto
```

> **José** não aparece na lista filtrada porque possui apenas **4 caracteres**, e o filtro utiliza `Length > 4`.

## Conceitos praticados

| Conceito          | Aplicação                                         |
| ----------------- | ------------------------------------------------- |
| `List<T>`         | Armazenamento dinâmico de dados                   |
| `Add()`           | Inserção de elementos                             |
| `foreach`         | Percorrer a lista                                 |
| Expressões lambda | Critério de filtragem                             |
| `FindAll()`       | Retorna todos os elementos que atendem à condição |
| `Length`          | Verifica a quantidade de caracteres da string     |

## Diferença entre `Find()` e `FindAll()`

| Método      | Retorno                                                              |
| ----------- | -------------------------------------------------------------------- |
| `Find()`    | Retorna apenas o primeiro elemento que atende à condição             |
| `FindAll()` | Retorna uma nova lista com todos os elementos que atendem à condição |

Exemplo:

```csharp
string primeiro = clientes.Find(cliente => cliente.Length > 4);
List<string> todos = clientes.FindAll(cliente => cliente.Length > 4);
```

## Aprendizados

Este exercício reforça o uso de listas dinâmicas em C#, mostrando como adicionar elementos, percorrer coleções e filtrar dados utilizando expressões lambda, uma habilidade muito utilizada no desenvolvimento com .NET.
