# Aula 02 — Constantes

> 🎯 **Conceito central:** declarar valores que nunca mudam durante a execução do programa.

---

## 📖 O que eu aprendi

Uma **constante** é uma variável que só pode receber valor **uma única vez**, no momento da declaração. Depois disso, qualquer tentativa de alterá-la nem chega a rodar: o erro aparece na **compilação**.

Isso é útil para valores universais (π, taxa de imposto, número máximo de tentativas). O compilador substitui a constante pelo valor literal ao compilar, então não há custo de desempenho.

## 💻 Código comentado

```csharp
const float PI = 3.14159f;   // const → valor fixo, definido em tempo de compilação
                             // o sufixo 'f' marca o literal como float
Console.WriteLine(PI);

// PI = 3.14;   ← isto NÃO compila: "a atribuição à esquerda deve ser variável"
```

## ▶️ Saída esperada

```
3,14159
```

> A vírgula aparece no lugar do ponto porque o Windows em português usa `,` como separador decimal.

## 🧠 Pontos de atenção

- **Por que o `f`?** Todo literal decimal em C# é `double` por padrão. Sem o `f`, o compilador reclama que não dá para converter `double` em `float` implicitamente (perda de precisão).
- **`const` vs `readonly`:** `const` é resolvido na compilação e só aceita valores literais. `readonly` é definido em tempo de execução (no construtor) e serve para valores que variam por instância.
- **Convenção de nome:** constantes costumam ser escritas em `PascalCase` no C# moderno (`Pi`), embora `MAIÚSCULAS` seja comum por herança de outras linguagens.
- Na prática, para π existe `Math.PI` — mais preciso e já pronto (usado na aula 03.3).

## 🔗 Próxima aula

[03 — Funções](../03%20-%20Fun%C3%A7%C3%B5es/) — organizando o código em blocos reutilizáveis.
