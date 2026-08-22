# 08 - Enum + Switch

## 📚 O que aprendi

Nesta aula aprendi a utilizar `enum` junto com a estrutura `switch`.

O objetivo foi criar um menu de opções e, de acordo com a opção escolhida pelo usuário, executar uma ação diferente.

## 💻 Exercício

Neste exercício criei um `enum` chamado `Opcao` com cinco opções:

* Criar
* Deletar
* Editar
* Listar
* Atualizar

Cada opção possui um valor numérico começando em `1`.

```csharp
enum Opcao
{
    Criar = 1,
    Deletar,
    Editar,
    Listar,
    Atualizar
}
```

Depois, o programa solicita ao usuário que escolha uma das opções e armazena a resposta em uma variável `int`.

## 🔄 Convertendo o valor para Enum

Depois de receber a opção do usuário, converti o valor `int` para o tipo `Opcao` utilizando cast:

```csharp
Opcao opcaoSelecionada = (Opcao)index;
```

Dessa forma, o número escolhido passa a representar uma das opções do `enum`.

## 🔀 Utilizando Switch

Depois utilizei um `switch` para verificar qual opção foi escolhida.

```csharp
switch (opcaoSelecionada)
{
    case Opcao.Criar:
        Console.WriteLine("Voce quer criar algo");
        break;

    case Opcao.Deletar:
        Console.WriteLine("Voce quer deletar algo");
        break;

    case Opcao.Editar:
        Console.WriteLine("Voce quer editar algo");
        break;

    case Opcao.Listar:
        Console.WriteLine("Voce quer listar algo");
        break;

    case Opcao.Atualizar:
        Console.WriteLine("Voce quer atualizar algo");
        break;
}
```

Cada `case` verifica uma opção diferente do `enum`.

Também utilizei `default` para tratar uma opção que não existe no `enum`:

```csharp
default:
    Console.WriteLine("Opcao não encontrada");
    break;
```

## 🧠 Conceitos praticados

* `enum`
* `switch`
* `case`
* `default`
* `break`
* `int.Parse()`
* Cast
* `Console.ReadLine()`
* `Console.WriteLine()`

## 📝 Minhas anotações

Neste exercício consegui juntar dois conceitos que aprendi anteriormente: `enum` e `switch`.

O `enum` foi utilizado para representar as opções do menu, enquanto o `switch` foi utilizado para verificar qual opção foi selecionada.

Também pratiquei a conversão de um número inteiro para um valor do `enum` utilizando cast.

## 🚀 O que consegui fazer

Consegui criar um menu simples no console onde o usuário escolhe uma opção através de um número e o programa identifica essa opção utilizando `enum` e `switch`.
