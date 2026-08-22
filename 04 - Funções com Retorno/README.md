# Aula 04 — Funções com Retorno

> 🎯 **Conceito central:** funções que devolvem um valor para quem as chamou.

---

## 📖 O que eu aprendi

Esta aula formaliza o que já vinha sendo usado nos exercícios: a diferença entre `void` e um tipo de retorno.

| | `void` | Tipo de retorno (`int`, `double`...) |
|---|---|---|
| Devolve valor? | Não | Sim, via `return` |
| Pode ser atribuída? | Não | Sim: `int x = Somar(1, 2);` |
| Uso típico | Exibir, salvar, enviar | Calcular, buscar, converter |

A regra de ouro que fixou: **função que calcula deve devolver, não imprimir**. Uma função que só faz `Console.WriteLine` fica presa ao console — não dá para reaproveitar em uma tela, em um arquivo ou em outro cálculo.

## 💻 Código comentado

```csharp
static void Main(string[] args)
{
    int soma1 = Somar(10, 20, 455);   // retorno guardado em variável
    Console.WriteLine(soma1);
}

static int Somar(int a, int b, int c)   // 3 parâmetros, retorno int
{
    int resultadoFinal = a + b + c;
    return resultadoFinal;              // devolve o valor e encerra o método
}
```

## ▶️ Saída esperada

```
485
```

## 🧠 Pontos de atenção

- **Todo caminho precisa retornar.** Se houver um `if` sem `else`, o compilador acusa *"nem todos os caminhos de código retornam um valor"*.
- **O tipo declarado é obrigatório.** Um método `int` não pode fazer `return 3.5;` sem cast.
- **Composição:** com retorno, dá para encadear — `Somar(Somar(1,2), 3, 4)` funciona.
- Este método poderia ser escrito em uma linha com *expression body*: `static int Somar(int a, int b, int c) => a + b + c;`
- **Parâmetros fixos são limitados.** Para somar uma quantidade variável de números, o caminho é um **array** — exatamente o tema da próxima aula.

## 🔗 Próxima aula

[05 — Arrays](../05%20-%20Arrays/)
