# Funções em Structs (C#)

Este projeto demonstra como criar e utilizar **structs** em C#, incluindo construtores e métodos para manipular os dados de uma estrutura.

## Objetivo

Praticar os seguintes conceitos da linguagem C#:

* Criação de `struct`
* Construtores
* Métodos dentro de uma `struct`
* Uso da palavra-chave `this`
* Cálculo de desconto com porcentagem
* Exibição de informações no console

## Código

```csharp
using System;

namespace _16___FuncoesEmStructs
{
    internal class Program
    {
        struct Produto
        {
            public string nome;
            public float preco;
            public float peso;
            public string marca;

            public Produto(string nome, float preco, float peso, string marca)
            {
                this.nome = nome;
                this.preco = preco;
                this.peso = peso;
                this.marca = marca;
            }

            public void ExibirInfo()
            {
                Console.WriteLine($"Nome: {this.nome}");
                Console.WriteLine($"Preço: R${this.preco}");
                Console.WriteLine($"Peso: {this.peso} KG");
                Console.WriteLine($"Marca: {this.marca}");
            }

            public float AdicionarCupom(float porc)
            {
                float desconto = this.preco * porc / 100f;
                return this.preco - desconto;
            }
        }

        static void Main(string[] args)
        {
            Produto iphone = new Produto("Iphone 18", 18000f, 200f, "Apple");
            Produto notebook = new Produto("Galaxy Book 6", 20000f, 1800f, "Samsung");

            iphone.ExibirInfo();

            Console.WriteLine("=================");

            notebook.ExibirInfo();

            Console.WriteLine("=================");
            Console.WriteLine("Com descontooooo");

            float valorFinal = iphone.AdicionarCupom(50f);
            Console.WriteLine(valorFinal);
        }
    }
}
```

## Como o programa funciona

O programa cria dois produtos utilizando a `struct Produto`:

* **iPhone 18** (Apple)
* **Galaxy Book 6** (Samsung)

Em seguida, ele:

1. Exibe as informações completas de cada produto.
2. Aplica um cupom de **50%** de desconto ao iPhone.
3. Exibe o valor final após o desconto.

## Exemplo de saída

```text
Nome: Iphone 18
Preço: R$18000
Peso: 200 KG
Marca: Apple

=================

Nome: Galaxy Book 6
Preço: R$20000
Peso: 1800 KG
Marca: Samsung

=================
Com descontooooo
9000
```

## Conceitos praticados

| Conceito              | Aplicação                       |
| --------------------- | ------------------------------- |
| `struct`              | Representação de um produto     |
| Construtor            | Inicialização dos atributos     |
| `this`                | Referência à instância atual    |
| Métodos               | Organização das funcionalidades |
| `Console.WriteLine()` | Exibição de informações         |
| Operações matemáticas | Cálculo do desconto             |

## Como executar

1. Clone o repositório.
2. Abra o projeto no **Visual Studio**.
3. Execute o programa (`Ctrl + F5`).

Ou pelo terminal:

```bash
dotnet run
```

## Aprendizados

Este exercício demonstra como uma `struct` pode armazenar tanto **dados** quanto **comportamentos**, utilizando métodos para organizar funcionalidades como exibição de informações e cálculo de descontos, tornando o código mais limpo e reutilizável.
