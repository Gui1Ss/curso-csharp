# Aula 05 — Arrays

> 🎯 **Conceito central:** armazenar vários valores do mesmo tipo em uma única variável.

---

## 📖 O que eu aprendi

Um **array** é uma sequência de posições contíguas na memória, todas do mesmo tipo e com **tamanho fixo** definido na criação.

### Duas formas de declarar

```csharp
// 1 — tamanho explícito + valores
string[] produtos = new string[5] { "Minecraft", "Fifa", "Code", "Fortnite", "Balatro" };

// 2 — forma curta: o compilador conta os elementos sozinho
int[] valores = { 30, 50, 60, 70, 80 };
```

### O índice começa em zero

```
Índice:     0            1        2         3           4
         ┌───────────┬────────┬────────┬───────────┬──────────┐
produtos │ Minecraft │  Fifa  │  Code  │ Fortnite  │ Balatro  │
         └───────────┴────────┴────────┴───────────┴──────────┘
```

`produtos[1]` é o **segundo** item. Isso explica a linha `produtos[1] = "Fifa 2026";` — ela substitui *Fifa*, não *Minecraft*.

## 💻 Código comentado

```csharp
string[] produtos = new string[5]
    { "Minecraft", "Fifa", "Code", "Fortnite", "Balatro" };

int[] valoress = { 30, 50, 60, 70, 80 };

produtos[1] = "Fifa 2026";     // arrays são mutáveis: o conteúdo pode mudar

for (int i = 0; i < produtos.Length; i++)   // .Length = quantidade de elementos
{
    Console.WriteLine(produtos[i]);
    Console.WriteLine(valoress[i]);          // arrays "paralelos": mesmo índice, dados relacionados
}
```

## ▶️ Saída esperada

```
Minecraft
30
Fifa 2026
50
Code
60
Fortnite
70
Balatro
80
```

## 🧠 Pontos de atenção

- **`i < Length`, nunca `i <=`.** Com 5 elementos os índices vão de `0` a `4`. Usar `<=` acessaria a posição `5`, que não existe → `IndexOutOfRangeException`.
- **`.Length` é propriedade, não método.** Não leva parênteses (diferente de `.Length()` em outras linguagens).
- **Tamanho é imutável.** Não existe "adicionar item" em array. Para coleções que crescem, o caminho é `List<T>`.
- **Arrays paralelos são frágeis.** `produtos[i]` e `valoress[i]` só se relacionam por convenção — se um array for reordenado, os pares se perdem. A solução definitiva é uma **classe** `Produto` com nome e preço juntos (assunto de POO).

## 📝 Exercício desta aula

[05.1 — Funções + Arrays](../05.1%20-%20Exerc%C3%ADcio%20-%20Fun%C3%A7%C3%B5es%20%2B%20Arrays/)
