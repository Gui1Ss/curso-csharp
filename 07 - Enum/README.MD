# 07 - Enum

## 📚 O que aprendi

Nesta aula aprendi sobre **Enums (`enum`)** em C#.

Um `enum` permite criar um conjunto de valores nomeados. No exercício, criei um `enum` chamado `Cor` com algumas cores.

## 💻 Exercício

Neste exercício criei um `enum` chamado `Cor` com as seguintes opções:

* Azul
* Amarelo
* Verde
* Vermelho
* Preto

Também defini que `Azul` teria o valor numérico `1`. A partir dele, os outros valores recebem números em sequência.

```csharp
enum Cor
{
    Azul = 1,
    Amarelo,
    Verde,
    Vermelho,
    Preto
};
```

## 🔢 Valores numéricos do Enum

Como defini `Azul = 1`, os valores ficam:

```text
Azul      = 1
Amarelo   = 2
Verde     = 3
Vermelho  = 4
Preto     = 5
```

Se eu não definisse o `Azul = 1`, o primeiro valor começaria em `0`.

## 🔄 Cast

Também aprendi a fazer **cast**, que é converter um tipo para outro.

No exercício, utilizei:

```csharp
Console.WriteLine((int)corFavorita);
```

Como `corFavorita` possui o valor `Cor.Preto`, o programa mostra `5` no console.

Também fiz o contrário:

```csharp
Console.WriteLine((Cor)5);
```

Nesse caso, o número `5` é convertido para o valor correspondente do `enum`, que é `Preto`.

## 🧠 Conceitos praticados

* `enum`
* Valores numéricos em `enum`
* Conversão de tipos
* Cast
* `(int)`
* `(Cor)`
* `Console.WriteLine()`

## 📝 Minhas anotações

Aprendi que os valores de um `enum` possuem valores numéricos internamente.

Também aprendi que posso converter um `enum` para `int` utilizando cast e também converter um número para o `enum` correspondente.

## 🚀 O que consegui fazer

Consegui criar meu primeiro `enum`, definir valores para suas opções e realizar conversões entre o `enum` e `int` utilizando cast.
