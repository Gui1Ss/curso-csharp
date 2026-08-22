# Exercício 03.1 — Primeiras Funções

> 🎯 **Desafio:** criar uma função que aplique um percentual de reajuste sobre um preço e devolva o valor final.

---

## 📖 O que eu aprendi

Este é o **primeiro método com `return`** do curso — e a diferença em relação à aula 03 é enorme. Como o valor é devolvido em vez de impresso, ele pode ser guardado em variáveis, somado, comparado ou passado adiante.

O mesmo método é chamado **duas vezes com argumentos diferentes**, e é exatamente aí que o reuso compensa: uma lógica escrita, dois resultados.

## 💻 Código comentado

```csharp
static void Main(string[] args)
{
    double chocolate    = PrecoFinal(30, 0.25);   // reajuste de 25% sobre 30
    double refrigerante = PrecoFinal(550, 0.25);  // mesma lógica, outro valor

    Console.WriteLine("Chocolate com aumento de 25% " + chocolate);
    Console.WriteLine("Refrigerante com aumento de 25% " + refrigerante);
}

static double PrecoFinal(double valorInicial, double ajuste)
{                                          // ↑ tipo de retorno: double
    double resultadoFinal = valorInicial * ajuste;   // calcula só o acréscimo
    resultadoFinal = resultadoFinal + valorInicial;  // soma ao valor original
    return resultadoFinal;                           // devolve para quem chamou
}
```

## ▶️ Saída esperada

```
Chocolate com aumento de 25% 37,5
Refrigerante com aumento de 25% 687,5
```

## 🧠 Pontos de atenção

- **O percentual entra como decimal.** `0.25` = 25%. Se eu passasse `25`, o preço ficaria 26× maior.
- **`return` encerra o método na hora.** Qualquer linha depois dele nunca executa.
- O cálculo em duas etapas é didático, mas dá para condensar: `return valorInicial * (1 + ajuste);`

## 🔗 Aula relacionada

[03 — Funções](../03%20-%20Fun%C3%A7%C3%B5es/)
